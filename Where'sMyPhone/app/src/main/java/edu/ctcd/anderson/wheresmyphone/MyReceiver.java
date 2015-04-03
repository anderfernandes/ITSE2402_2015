package edu.ctcd.anderson.wheresmyphone;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.telephony.*;
import android.widget.Toast;
import android.location.*;
import android.media.MediaPlayer;

public class MyReceiver extends BroadcastReceiver implements LocationListener{
    // Instance variables
    String loc = "Location unknown";
    LocationManager mgr;
    String provider;

    public MyReceiver() {
    }

    @Override
    public void onReceive(Context context, Intent intent) {
        SharedPreferences passwdfile = context.getSharedPreferences("password", 0);
        String password = passwdfile.getString("password", null);

        mgr = (LocationManager) context.getSystemService(Context.LOCATION_SERVICE);
        Criteria criteria = new Criteria();
        criteria.setAccuracy(Criteria.ACCURACY_FINE);
        criteria.setPowerRequirement(Criteria.POWER_LOW); criteria.setCostAllowed(true);
        provider = mgr.getBestProvider(criteria, true);
        mgr.requestLocationUpdates(provider, 0, 0, (LocationListener)this);
        Location lastLocation = mgr.getLastKnownLocation(provider);
        if(lastLocation != null) loc = "Findme Latitude: "
                + lastLocation.getLatitude() + "\nLongitude: "
                + lastLocation.getLongitude();

        // Get the messages - PDU = protocol description unit
        Bundle bundle = intent.getExtras();
        Object[] pdusObj = (Object[]) bundle.get("pdus");
        SmsMessage[] messages = new SmsMessage[pdusObj.length];
        for (int i = 0; i < pdusObj.length; i++) {
            messages[i] = SmsMessage.createFromPdu((byte[])pdusObj[i]);
        }
        for (SmsMessage msg : messages){
            // Make sure it's a findme message
            if(msg.getMessageBody().contains("findme:" + password)) {
                String to = msg.getOriginatingAddress();
                SmsManager sm = SmsManager.getDefault();
                sm.sendTextMessage(to, null, loc, null, null);
                Toast.makeText(context, "Location sent to: "
                                + to + " using provider: "
                                + provider, Toast.LENGTH_LONG).show();
                MediaPlayer mp = MediaPlayer.create(context, R.raw.keys1);
                mp.start();
            }

        }
    }

    @Override
    public void onLocationChanged(Location location) {
        // Get location and store in loc
        if(location == null) {
            location = mgr.getLastKnownLocation(provider);
        }
        loc = "Findme Latitude: " + location.getLatitude() + "\nLongitude: "
                + location.getLongitude();
    }

    @Override
    public void onStatusChanged(String provider, int status, Bundle extras) {

    }

    @Override
    public void onProviderEnabled(String provider) {

    }

    @Override
    public void onProviderDisabled(String provider) {

    }
}

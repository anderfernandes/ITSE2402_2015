package edu.ctcd.anderson.wheresmyphone;

import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.content.SharedPreferences.Editor;
import android.view.*;
import android.view.View.OnClickListener;
import android.widget.*;


public class MainActivity extends ActionBarActivity implements OnClickListener {

    // Instance variables
    private Button start;
    private EditText pword;
    private EditText confirm;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Instantiating objects
        start = (Button)findViewById(R.id.button);
        pword = (EditText)findViewById(R.id.editText);
        confirm = (EditText)findViewById(R.id.editText2);

        // Registering button with listener
        start.setOnClickListener(this);
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    // Implementing the onClick() method of the OnClickListener interface
    @Override
    public void onClick(View v) {
        String pass = pword.getText().toString();
        String conf = confirm.getText().toString();
        // Check that user typed a password
        if (pass.length() == 0) {
            Toast.makeText(this, "Please enter a password", Toast.LENGTH_SHORT).show();
            pword.requestFocus();
            return;
        } // Make sure two fields match
        if (pass.equals(conf)) {
            // Fields match, store password in shared preferences
            Editor passwdfile = getSharedPreferences("password", 0).edit();
            passwdfile.putString("password", pass);
            passwdfile.apply();
            finish();
        } else {
            // Password mismatch - start over
            Toast.makeText(this, "Passwords must match", Toast.LENGTH_SHORT).show();
            pword.setText("");
            pword.requestFocus();
        }
    }
}

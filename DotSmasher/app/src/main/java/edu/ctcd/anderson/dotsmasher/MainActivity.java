package edu.ctcd.anderson.dotsmasher;

import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import java.util.Timer;
import android.view.*;


public class MainActivity extends ActionBarActivity {

    // Instance variables for the class
    private Timer timer;
    private DotSmasherCanvas canvas;
    private DotSmasherTimerTask task;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_main);
        setTitle("Andersoft DotSmasher 1.0");
        canvas = new DotSmasherCanvas(getBaseContext());
        timer = new Timer();
        task = new DotSmasherTimerTask(canvas);
        timer.schedule(task, 0, 500); // CHANGE THIS VALUE TO MAKE THE DOT MOVE FASTER
        setContentView(canvas);
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
       switch (item.getItemId()){
           case R.id.item1:
               newGame();
               return true;
           case R.id.item2:
               quit();
               return true;
           default:
               return super.onOptionsItemSelected(item);
       }
    }

    public void newGame() {
        canvas.setScore(0);
    }

    public void quit() {
        timer.cancel();
        task = null;
        timer = null;
        finish();
    }
}

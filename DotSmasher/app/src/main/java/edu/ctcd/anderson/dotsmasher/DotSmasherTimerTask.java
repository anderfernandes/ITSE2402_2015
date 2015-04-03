package edu.ctcd.anderson.dotsmasher;

import java.util.TimerTask;

/**
 * Created by AdvUser on 2/24/2015.
 */
public class DotSmasherTimerTask extends TimerTask {
    DotSmasherCanvas canvas;
    public DotSmasherTimerTask(DotSmasherCanvas canvas) {
        this.canvas = canvas;
    }
    @Override
    public void run() {
        canvas.moveDot();
        canvas.postInvalidate();
    }
}

package edu.ctcd.anderson.dotsmasher;

import android.content.Context;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnTouchListener;
import android.graphics.*;

import java.util.Random;

/**
 * Created by AdvUser on 2/24/2015.
 */
public class DotSmasherCanvas extends View implements View.OnTouchListener {

    // Instances variable for the dot location and score
    int dotX, dotY, score;

    // Accessor and Mutator for dotX
    public int getDotX() {
        return dotX;
    }

    public void setDotX(int dotX) {
        this.dotX = dotX;
    }

    // Accessor and Mutator for dotY
    public int getDotY() {
        return dotY;
    }

    public void setDotY(int dotY) {
        this.dotY = dotY;
    }

    // Accessor and Mutator for score
    public int getScore() {
        return score;
    }

    public void setScore(int score) {
        this.score = score;
    }

    public DotSmasherCanvas(Context context) {
        super(context);
        moveDot();
        setOnTouchListener(this);
    }

    public DotSmasherCanvas(Context context, AttributeSet attrs) {
        super(context, attrs);
    }

    public DotSmasherCanvas(Context context, AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);
    }

    @Override
    public boolean onTouch(View v, MotionEvent event) {
        if (detectHit((int)event.getX(), (int)event.getY())) {
            score += 1;
            invalidate();
        }
        return false;
    }

    protected void moveDot() {

        // Create two numbers, assign random numbers to dotX and dotY

        Random generator = new Random();
        generator.setSeed(System.currentTimeMillis());
        int w = getWidth() - 20; // to void covering score
        int h = getHeight() - 40; // to avoid covering score
        float f = generator.nextFloat();
        dotX = (int)(f * w) % w;
        f = generator.nextFloat();
        dotY = (int)(f * h) % h;
    }

    protected boolean detectHit(int x, int y){
        if((x >= dotX && x <= dotX + 20) && (y >= dotY && y <= dotY + 20)){
            // You have a hit
            return true;
        }
        return false;
    }

    @Override
    protected void onDraw(Canvas canvas) {
        canvas.drawColor(Color.BLACK);
        Paint dotPaint = new Paint();
        dotPaint.setColor(Color.RED);
        canvas.drawRect(dotX, dotY, dotX + 20, dotY + 20, dotPaint);
        canvas.drawText("Score: " + score, 20, 20, dotPaint);
    }
}

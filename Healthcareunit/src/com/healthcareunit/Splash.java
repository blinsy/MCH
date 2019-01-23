package com.healthcareunit;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;

public class Splash extends Activity {
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.splash);
		Load();
		
	}
	
	private void Load(){
		
		Handler handler = new Handler();
		handler.postDelayed(new Runnable() {
			
			@Override
			public void run() {
				// TODO Auto-generated method stub
				Intent mymain = new Intent(Splash.this,MainActivity.class);
				startActivity(mymain);
				finish();
				
			}
		}, 3000);
	}
	

}

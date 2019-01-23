package com.healthcareunit;
import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.Toast;
public class MainActivity extends Activity {
	LinearLayout search,aile,mum,consult,remind,setting;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		search=(LinearLayout)findViewById(R.id.easysearch);
		aile=(LinearLayout)findViewById(R.id.ailements);
		mum=(LinearLayout)findViewById(R.id.mother);
		consult=(LinearLayout)findViewById(R.id.consulting);
		remind=(LinearLayout)findViewById(R.id.reminder);
		setting=(LinearLayout)findViewById(R.id.settings);
		
		
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

	public void ClicksHandler(View view){
		switch(view.getId()){
		case R.id.easysearch:
			Toast.makeText(getApplicationContext(), "Easy Search Selected ", Toast.LENGTH_LONG).show();
			Intent i=new Intent(MainActivity.this,Easysearch.class);
			startActivity(i);
			break;
			
		case R.id.ailements:
			Toast.makeText(getApplicationContext(), "Ailements selected", Toast.LENGTH_LONG).show();
			Intent  a=new Intent(MainActivity.this,Ailements.class);
			startActivity(a);
			break;
			
		case R.id.mother:
			Toast.makeText(getApplicationContext(), "Mother and child selected", Toast.LENGTH_LONG).show();
			Intent b=new Intent(MainActivity.this,Mother.class);
			startActivity(b);
			break;
			
			
		case R.id.consulting:
			Toast.makeText(getApplicationContext(), "Easy consulting selected", Toast.LENGTH_LONG).show();
			Intent c=new Intent(MainActivity.this,Consulting.class);
			startActivity(c);
			break;
			
		case R.id.reminder:
			Toast.makeText(getApplicationContext(), "Reminders and notifications", Toast.LENGTH_LONG).show();
			Intent d=new Intent(MainActivity.this,Reminder.class);
			startActivity(d);
			break;
			
		case R.id.settings:
			Toast.makeText(getApplicationContext(), "profile and settings selected", Toast.LENGTH_LONG).show();
			Intent e=new Intent(MainActivity.this,Settings.class);
			startActivity(e);
			break;
		
		}
	}
}

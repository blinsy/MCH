package com.healthcareunit;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.Toast;

public class Mother extends Activity {
	
	LinearLayout one,two,three,four,five;


	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.mother);
		
		one=(LinearLayout)findViewById(R.id.antenatal);
		two=(LinearLayout)findViewById(R.id.postnatal);
		three=(LinearLayout)findViewById(R.id.babycard);
		four=(LinearLayout)findViewById(R.id.fertility);
		five=(LinearLayout)findViewById(R.id.practitioner);
		
	}
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}
	
	
	
	public void ClicksHandler(View view){
		switch(view.getId()){
		case R.id.antenatal:
			Toast.makeText(this, "Antenatal care selected", Toast.LENGTH_LONG).show();
			Intent i=new Intent(getApplicationContext(),Antenatal.class);
			startActivity(i);
			break;
			
		case R.id.postnatal:
			Toast.makeText(this, "Postnatal care selected", Toast.LENGTH_LONG).show();
			Intent j=new Intent(getApplicationContext(),Postnatal.class);
			startActivity(j);
			break;
			
		case R.id.babycard:
			Toast.makeText(this, "Baby's card  selected", Toast.LENGTH_LONG).show();
			Intent k=new Intent(getApplicationContext(),Babycard.class);
			startActivity(k);
			break;
			
		case R.id.fertility:
			Toast.makeText(this, "Fertility selected", Toast.LENGTH_LONG).show();
			Intent m=new Intent(getApplicationContext(),Fertility.class);
			startActivity(m);
			break;
			
		case R.id.practitioner:
			Toast.makeText(this, "Antenatal care selected", Toast.LENGTH_LONG).show();
			Intent n=new Intent(getApplicationContext(),Practitioner.class);
			startActivity(n);
			break;
}
}}
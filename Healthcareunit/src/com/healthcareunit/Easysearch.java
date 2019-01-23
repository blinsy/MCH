package com.healthcareunit;


import java.util.ArrayList;
import java.util.List;

import android.app.Activity;
import android.os.Bundle;

import data.SearchData;

public class Easysearch extends Activity{
	
	private List<SearchData>searchdata;	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.easysearch);		
		searchdata=new ArrayList<SearchData>();
		searchdata.add(new SearchData("Allergy Symptoms", "Running nose, itchy eyes, nasal congestion, headache, skin reactions, diarrhea, breathing difficulties, itchy rashes, swollen eyes, itching throat and nose\n\n\nAdvice:- Contact a doctor immediately "));			
		searchdata.add(new SearchData("Malaria Symptoms", "Pain in joints, headache, tiredness, cough, fever, diarrhea, jaundice, sweating, vomiting, low blood pressure\n\n\n Advice: Contact a doctor immediately"));			
		searchdata.add(new SearchData("Typhoid Symptoms", "Fever, stomach pains, flat and pink coloured spots, headaches, diarrhea, poor appetite, aches and pains, lethargy, constipation\n\n\n Advice: Contact a doctor immediately"));	
		searchdata.add(new SearchData("Ebola Symptoms ", "Sore throat, severe headaches, muscle pain, weaknesses, diarrhea, vomiting, stomach pain, bleeding or bruising (unexpected hemorrhage)\n\n\n Advice: Contact a doctor immediately"));
		searchdata.add(new SearchData("Pneumonia Symptoms", "Cough either green or yellow mucus), fever, shaking chills, shortness of breath, weaknesses, muscle pain \n\n\nAdvice: Contact a doctor immediately"));	
		searchdata.add(new SearchData("Cholera Symptoms", "Diarrhea, nausea, vomiting, dehydration, coma, seizures, altered state of consciousness \n\n\nAdvice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Heart disease Symptoms", "Shortness of breath Palpitations, nausea Weaknesses, sweating, pain in the neck, jaw, throat, upper abdomen, fainting, chest pain discomfort in chest, racing heartbeat, fatigue, fever, swelling legs, dry or persistent cough, skin rashes\n\n\nAdvice: Contact a doctor immediately "));	
		searchdata.add(new SearchData("High blood pressure Symptoms", "Severe headache, fatigue, vision problems, chest, difficulty breathing, irregular heartbeat, blood in urine\n\n\n Advice: Seek medical help immediately "));
		searchdata.add(new SearchData("Hepatitis Symptoms", "Dark urine, loss appetite, mild fever, muscle or joint pain, nausea and vomiting, weakness, fatigue, jaundice, clay – coloured bowel movements\n\n\n Advice: Contact a doctor immediately "));			
		searchdata.add(new SearchData("ACNE Symptoms", "Nodules, pimples are red with white pus at tips papules, cysts, comedones\n\n\n Advice: Contact a doctor immediately "));		
		searchdata.add(new SearchData("Arthritis Symptoms", "Fatigue, joint pain, joint tenderness, joint swelling, joint redness, joint warmth, stiffness of joints\n\n\n Advice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Asthma Symptoms", "Coughing, wheezing, shortness of breath, chest tightness, pain pressure \n\n\nAdvice: Contact a doctor immediately "));	
		searchdata.add(new SearchData("Brain cancer Symptoms", "Headaches, nausea, vomiting, vision problems, loss of sensation or movement in leg, imbalance in posture, speech difficulties, seizures, confusion, hearing problems \n\n\nAdvice: Contact a doctor immediately "));	
		searchdata.add(new SearchData("Breast cancer Symptoms", "Lump or inflammation on the breast, lump in the armpit, breast shape change, skin changes, nipple changes, bone pain, nausea, loss of appetite, weight loss, jaundice, headache, double vision, muscle weakness \n\n\nAdvice :-Seek medical help immediately"));
		searchdata.add(new SearchData("Lung cancer Symptoms", "Cough, chest infections, coughing up blood, an ache or pain when breathing, shortness of breath, change in voice or hearse, coughing up mucus, blood clots, bleeding, neck or facial swelling, bone fractures not related to accident injury, fatigue, muscle wasting, loss of appetite \n\n\n\nAdvice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Chicken pox Symptoms", "Feeling sick, high temperature, aching, painful muscle, headache, loss of appetite, feeling unwell\n\n\n Advice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Common cold Symptoms", "Running nose, itchy throat, cough, congestion sneezing, watery eyes, fever\n\n\n Advice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Diabetes Symptoms", "Frequent urinating, extreme tiredness, weight loss, genital itching, slow healing of cuts and wounds, blurred vision\n\n\nAdvice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Diphtheria Symptoms", "Drooling, sore throat, bluish skin, a loud cough, fever, chills, swollen lymph, nodes in the neck, difficulty breathing, fatigue\n\n\n Advice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Epilepsy Symptoms", "Temporary confusion Loss of consciousness Uncontrollable jerrying movements Staring \n\n\n\nAdvice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Gonorrhea Symptoms", "Pain, vaginal discharge, pain in the lower abdomen, bleeding, inflammation, pain or tenderness in the testicles, yellow, white or green discharge from penis\n\n\nAdvice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Gerd Symptoms", "Heart burn, chest pain, difficulty swallowing, dry cough, sore throat, sensations of lump in your throat, acid reflux \n\n\nAdvice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Goiter Symptoms", "Difficulty breathing and swallowing, coughing, a tight feeling in your throat, hear nesses\n\n\n Advice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Leukemia Symptoms", "Headaches, shortness of breath, bone/joint part, night sweats, loss of appetite, weight loss, fatigue, weakness, fever, chills, bleeding, small red spots under the skin\n\n\n Advice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Meningitis Symptoms", "Seizure, shivering, fast breathing, mental changes, drowsiness or difficulty a wakening, irritability, stiff or jerk movements, joint pain discomfort in bright lights, nausea, vomiting, neck stiffness, severe headache, sudden high fever\n\n\n  Advice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Stroke Symptoms", "Numbness or weakness Confusion, trouble speaking Trouble seeing Trouble walking Severe headaches \n\n\nAdvice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Cataracts Symptoms", "Crowded, blurred vision Sensitivity to light and glare Double vision Fading or yellowing of colours \n\n\nAdvice: Contact a doctor immediately"));
		searchdata.add(new SearchData("Ulcers Symptoms", "Nausea, heart burn, bloating, blood black, tarry stools, abdominal pain\n\n\n Advice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Tuberculosis Symptoms", "Cough, pain in chest, blood coughs, sputum, weakness, fatigue, weight loss, no appetite, chills, fever \n\n\nAdvice: Contact a doctor immediately"));
		searchdata.add(new SearchData("Syphilis Symptoms", "Skin rashes, heart disease, deafness, blindness, paralysis, numbness, loss of coordination, dementia, stroke, headaches, joint pains, fever, small skin growths appear at the anus, swollen lymph nodes, weight loss, patching hair loss, non-itchy skin rash, painless sore.\n\n\n Advice: Contact a doctor immediately "));
		searchdata.add(new SearchData("Mumps Symptoms", "Headaches, joint pain, feeling sick, dry mild, abdominal pain, feeling tired, loss appetite, high temperatures\n\n\n Advice: Contact a doctor immediately "));
		
	}

}

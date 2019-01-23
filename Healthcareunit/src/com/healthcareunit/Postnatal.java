package com.healthcareunit;
import java.util.ArrayList;
import java.util.List;
import data.PostnatalData;
import android.app.Activity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;
public class Postnatal extends Activity {
private List<PostnatalData>postnatalData;
private int AmAtPage=-1;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.postnatal);		
		ProgressDialog dialog = new ProgressDialog(this);
		dialog.setMessage("Please wait...");
		dialog.show();
		postnatalData = new ArrayList<PostnatalData>();
		postnatalData.add(new PostnatalData("POSTNATAL CARE\nYour babys most common ailments", "Seeing your child suffer through any type of illness is a heart wrenching and sometimes scary experience. Avail yourself with information on dozens of conditions like allergies, vomiting the flue, cough and colds constipation, ear infections, diarrhea, fever, rashes and skin conditions such as baby ache and ringworm and also diaper rashes."));
		postnatalData.add(new PostnatalData("Methods of checking of babys temperature is as follows:-","-Temporal artery thermometers\n -Oral thermometers\n-Pacifier thermometers (most doctors do not recommend this because readings are more likely to be inaccurate than a temperature taken rectally, orally or under arm.\n-Rectal thermometers\n-Ear thermometers."));
		postnatalData.add(new PostnatalData("Your baby`s immunization", "Immunizations prevent your baby from getting vaccine preventable diseases. Please engage your doctor further on immunizations programs for these diseases available for your baby`s"));
		postnatalData.add(new PostnatalData("These diseases are:-", "Diphtheria, hepatitis B, influenza, measles, meningococcal disease, mumps, pneumococcal disease, polio, rota virus, rubella, tetanus, varicella (chicken pox), whooping cough "));
		postnatalData.add(new PostnatalData("Your baby`s diet", "Introducing solid foods often known as weaning should begin when the baby is 6 months old. How much your baby takes is less important than being used to the idea of eating. At this stage they will still get most of their nutrition from breast milk or infant formula. Babies don't need three meals at a time but you can start introducing foods at a time. Eventually you`ll be able to increase the amount they eat gradually and possibly eat the same as the rest of the families in smaller proportions. Infant formula or breast milk is key in the first 6 months since it builds the baby`s immune system and also develops the baby`s digestive system with time so that it can cope fully with the coming solid foods. "));
		postnatalData.add(new PostnatalData("Signs that the baby is ready for their first solid foods are as follows:-", "-Can stay steady in sitting position and hold their head firm.\n-Can voluntary swallow food, the one who are not ready will push their food back.\n-Can coordinate their eyes, hands and mouth so that they can look at the food, pick it up and put it in their mouth, all by themselves."));
		postnatalData.add(new PostnatalData("Signs that show the baby is not ready for food?", "Chewing fists Wanting extra milk feedsWaking in the night when they have previously slept through."));
		postnatalData.add(new PostnatalData("Best feeding practice of a baby", "-Stay with your baby when eating incase they choose\n-Allow them to feed themselves, as soon as they show interest, using their fingers.\n-Let the baby enjoy touching and holding food.\n-Dont force the baby to eat.				  -If you are using a spoon, wait for your baby to open their mouth before you offer the food.				  -Cool hot food and test it before giving it to your baby.				  -Dont add salt, sugar to your baby`s food or cooking water.				  -Introducing to solid foods, start by offering a few pieces or tea spoons of food, once a day"));
		postnatalData.add(new PostnatalData("Your baby`s clothes", "It essential you arrange your baby`s clothes in regard to sex, height, weight and other related factors."));
		postnatalData.add(new PostnatalData("This is the baby`s clothes checklist as:-", "Sleep suits ` comfy, cosy and soft are ideal for any new born baby Body suits \n` cotton layered suits will be vital Jackets \n` comfy jackets Out fits \n` cardigans, simple fitting and joggers for your baby Knit wear \n` essential for keeping baby cosy Accessories \n` tie top hats, socks, bibs and scratch mitts are new born essential for warmth "));
		postnatalData.add(new PostnatalData("Your baby`s sleep songs/melodies", "Just as food nourishes a baby`s growing body, the elements of melody, tone and harmony nourish a baby`s rapidly developing brain. Music has a vital role in fetal developing neurons which helps in learning and keeping them alert"));
		postnatalData.add(new PostnatalData("Your baby`s school starts up", "If you have a child that has deep interest in art, music and dance, find out how you can encourage develop his/her creative skills"));
		postnatalData.add(new PostnatalData("Signs that will show you your child is ready for school.", "-Is he/she receptive and curious in learning new things 			 -Does he/she have a good relationship with other children?				  -Can he/she be able to even brush his/her teeth with a tooth brush				  -Can he/she work with others in harmony in a group?				  -Can he/she put on his coat, shoes and go to the loo by himself/herself?				  -Can your child listen to instructions? "));
		postnatalData.add(new PostnatalData("Your baby`s nannies/house helps", "When looking for nannies you should identify your priorities, age, experience, education of the nanny. Do an extensive research, involves your friends and relatives and tell them what exactly you need. "));
		postnatalData.add(new PostnatalData("Signs of a good house help", "-She`s timely			  -She`s connected, gives updates on the progress at home and the kids				  -She`s creative and easily bonds with children especially in imaginative responses and drills children`s curiosity				  -Your child`s room is clean and so is your child				  -She`s responsive to problems, and will always look for a possible solution with you to provide the best possible childcare				  -Children will be comfortable and happy to be around her and children will always be saying wonderful stories about her				  -Children yearn for that time they spend with their nanny				  -She embraces safety at home, fewer incidences of accidents can occur at her supervision "));
		postnatalData.add(new PostnatalData("Prenatal and postnatal workouts", "Consult with your doctor or midwife before starting any postnatal or prenatal exercise"));
		postnatalData.add(new PostnatalData("Types of any postnatal exercise", "-Brisk walking				  -Yoga				  -Pilates				  -Low impact work outs				  -Light weight training				  -Cycling 				  -Swimming "));
		postnatalData.add(new PostnatalData("Types of prenatal exercise", "Walking, swimming, cycling, outdoors or on standing bike, aquaerobics, yoga, stretching and other floor exercise classes. Note: Some of the activities should be done in moderation by pregnant women especially in women who had already been participating in these activities prior to pregnancy i.e. running and strength training "));
		postnatalData.add(new PostnatalData("Exercises to avoid during pregnancy", "-Contact sports i.e. skiing, horse riding etc.				 - Competition sports				 - Activities that involve jumping, frequent changes of direction i.e. such as gymnastics in pregnancy				 - Avoid exercise that involves lying on your back instead try to modify by lying on your side."));
		postnatalData.add(new PostnatalData("Warming signs when exercising are?", "Headache, chest pains, swelling of the face, hands or feet, vaginal bleeding, contractions, deep back pain or pubic pain, walking difficulties, amniotic fluid leakage, unusual shortness or breath, dizziness, heart palpitations if you experience the above, contact your doctor, midwife, physiotherapist immediately "));
		postnatalData.add(new PostnatalData("Your baby`s photo album", "Its vital to keep track of baby development through a photo album, that is either individual, family and group photo, for every event in a baby`s life."));
		postnatalData.add(new PostnatalData("Prenatal tests", "Prenatal tests can help identity health problems that could endanger both a woman and her unborn, child, some of which are treatable. However there tests do have limitations. As an expectant parent, it’s vital to educate yourself about them and to think about what you would do if a health problem was detected. "));
		postnatalData.add(new PostnatalData("Test in a mother", "-Her blood type				 - Whether she has gestational diabetes, anaemia or other health conditions.				 - Her immunity to certain diseases				 - Whether she has cervical cancer or STD "));
		postnatalData.add(new PostnatalData("Test in a developing child.", "-Treatable health conditions that can affect the baby’s healthy characteristics i.e size, sex, age and placement in the uterus.				 - Chance the baby has a certain birth defect or genetic problems.				 - Certain types of fetal abnormalities. i.e. heart problems."));
		postnatalData.add(new PostnatalData("Other routine tests for certain women especially high risk pregnancy. This may include", "Age 35 and above				  Are adolescents 				  Have had a premature baby				  Have had a baby with birth defect or genetic problems.				  Are carrying more than one baby.				  Have high blood pressure, diabetes, heart disease, kidney problems, and cancer, STDs, asthma or seizure disorders.				  Have a genetic disorders family history or a partner who does.				  Have a family history of mental retardation or partner who does."));
	 				 
				 
				 
		dialog.dismiss();
		ShowNext(null);
	}

	public void ShowNext(View view){
		
		if(AmAtPage < postnatalData.size()-1){
			AmAtPage++;
			((TextView)findViewById(R.id.pageat)).setText((AmAtPage+1)+" of "+postnatalData.size());
		((TextView)findViewById(R.id.header)).setText(postnatalData.get(AmAtPage).getHeader());
		((TextView)findViewById(R.id.description)).setText(postnatalData.get(AmAtPage).getDescription());
		
		}
		else {
			Toast.makeText(this, "This is the last page", Toast.LENGTH_LONG).show();
		}
		}
	public void ShowPrevius(View view){
		
		if(AmAtPage >0){
			AmAtPage--;
			((TextView)findViewById(R.id.pageat)).setText((AmAtPage+1)+" of "+postnatalData.size());
		((TextView)findViewById(R.id.header)).setText(postnatalData.get(AmAtPage).getHeader());
		((TextView)findViewById(R.id.description)).setText(postnatalData.get(AmAtPage).getDescription());
		
		}
		else {
			Toast.makeText(this, "This is the first page", Toast.LENGTH_LONG).show();
		}
		}
	public void Share(View view){
		Intent intent = new Intent(Intent.ACTION_SEND);
		intent.setType("text/plain");
		intent.setPackage("com.whatsapp");
		intent.putExtra(Intent.EXTRA_TEXT, postnatalData.get(AmAtPage).getDescription()+"");
		try{
		startActivity(intent);
		}catch (Exception e) {
			// TODO: handle exception
			Toast.makeText(this, "Hey download whatsapp", Toast.LENGTH_LONG).show();
		}
	}
	}
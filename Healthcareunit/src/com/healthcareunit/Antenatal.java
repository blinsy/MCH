package com.healthcareunit;


import java.util.ArrayList;
import java.util.List;

import data.AntenatalData;

import android.app.Activity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;
public class Antenatal extends Activity {
private List<AntenatalData> antenatalData;
private int AmAtPage=-1;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.antenatal);		
		ProgressDialog dialog = new ProgressDialog(this);
		dialog.setMessage("Please wait...");
		dialog.show();		
		antenatalData = new ArrayList<AntenatalData>();
		antenatalData.add(new AntenatalData("Your hospital visit", "Your first step in antenatal is a visit to the hospital or clinic to your medical practitioners to have your pregnancy confirmed. Preliminary test, will be done on you and using the date of your last monthly period they will estimate the date the baby is due or expected date of delivery Your practitioner will discuss options on antenatal care and the maternity hospital you prefer to give birth in. Your first hospital visit takes quite a while; this is because of large information recorded may range from providing you with contacts you may need during pregnancy such as pre-child birth, classes, physiotherapy services, dieticians, social workers."));
		antenatalData.add(new AntenatalData("1 Private care","You are guaranteed by your own consultant hospital on every hospital visits or consultant private rooms. Private health insurance cover and your private hospital stay, however your health insurance provider may not cover all your fees, this is subject to the kind of insurance cover you are on. However please get a detailed list of all charges before you make your decision. After delivery you will be transferred to a private room if available. "));
		antenatalData.add(new AntenatalData("2 Mid wives services","This service is suitable for women with no or minimum complications as low risk pregnancies. This service a mother has an option of giving birth at home or hospital. If complications develops during pregnancy a woman is transferred back to full hospital service"));
		antenatalData.add(new AntenatalData("3 Home birth delivery early transfer to home","You are guaranteed by your own consultant hospital on every hospital visits or consultant private rooms. Private health insurance cover and your private hospital stay, however your health insurance provider may not cover all your fees, this is subject to the kind of insurance cover you are on. However please get a detailed list of all charges before you make your decision. After delivery you will be transferred to a private room if available. "));
		antenatalData.add(new AntenatalData("4 Public care","Public care offers free maternity care for all women living in Kenya regardless of any health insurance they hold, in this facility you are not guaranteed that you will be seen by the same doctor/midwife at each visit. Midwives attends to you when in labour, you will only see a doctor on duty if you need an assisted birth or caesarean section. After birth you will be moved to the public ward for your stay, generally this will be about three days"));
		antenatalData.add(new AntenatalData("Benefits of midwives","- Monitoring the physical psychological and social well being of mother throughout childbearing cycle.\n -Minimizing technological interventions.\n -Identifying and referring women who require specialized medical attention providing to mother, prenatal care, continuous hands on assistance during pregnancy and postnatal care support. "));
		antenatalData.add(new AntenatalData("Antenatal hospital visits\n First antenatal appointment","This can be anytime from 12-20 weeks of pregnancy. The purpose of this visit is to have an understanding of your health and that of the unborn. Questions from this meeting will range from your own personal medical history of your family. This will be based on past and current medical details and any medication that you may be taking. Urine sample will be taken from you; your blood pressure checked and undergoes a number of blood test. The purpose of these tests will be explained to you. In some hospitals you may undergo an ultra sound scan on your visits in others you will at 20 weeks. Subsequent visits will be shorter if your pregnancy is normal but the first visit takes approximately 1-2hrs. At every subsequent antenatal visits, your sample will be taken and blood pressure will be taken and you will be examined. Uterus will be checked to determine your foetal size, position will be checked and also the heart beat will also be checked for the unborn (twice as fast as yours). In the last month of pregnancy, an internal examination maybe carried out where your cervix will be checked and your pelvic size assessed. If you have any queries contact your midwife or doctor for more information related to your pregnancy."));
		antenatalData.add(new AntenatalData("PREGNANCY DISCOMFORTS\n(i)First three months ","Morning sickness is accompanied with vomiting during early pregnancy. Most pregnant women but not all experience morning sickness to some extent, it can happen anytime of the day but usually settles after the first three months "));
		antenatalData.add(new AntenatalData("What to do when you experience morning sickness","-Drink plenty of fluids between meals rather than with meals \n-Please avoid strong aromas/odours that may cause nausea \n-Avoid foods high in fat as they are likely to increase nausea i.e. fried foods, takeaways and crisps, trim visible fat off meat before cooking \n-Avoid having an empty stomach, eat small meals regularly. It may help to cut dry crackers or biscuits between meals and before you get out of bed in the morning \n-Incase it persists discuss the complaint with your doctor if it becomes severe"));
		antenatalData.add(new AntenatalData("Breast changes","– Increase in size and some tenderness is noticeable, very early during your pregnancy and it can last for the entire pregnancy. \nYou may need larger and supportive bras;\n also some women will have a clear discharge from their nipples and may need to use shields or nursing pads to protect their clothing"));
		antenatalData.add(new AntenatalData("Frequent urination","– Happens early in pregnancy when the expanding uterus pushes against the bladder, it may improve mid-pregnancy but reoccur during later in pregnancy "));
		antenatalData.add(new AntenatalData("What to do?","-Limit your fluid content in the evening but be careful if you limit your overall fluid intake as you may become constipated\n -If you experience burning or pain with urination, this may indicate a bladder infection, always discuss this with your healthcare provider"));
		antenatalData.add(new AntenatalData("(ii)Second three months Heart burn","Its a form of indication common in pregnancy, particularly the later stages, caused by stomach acid flowing up the oesophagus;\n this condition has nothing to do with the heart. It is often associated as a burning sensation in the stomach and throat area. "));
		antenatalData.add(new AntenatalData("What to do","-Eat small meals regularly and eat slowly, chewing your food well.\n-Try separating fluids from eating-Avoid spicy or greasy fatty foods\n-Eat while sitting up-Give yourself atleast 1-2 hrs after eating before lying down-Avoid alcohol and coffee\n-Take a glass of milk before going to bed to neutralize the acid in your stomach\n-Engage your doctor with this complaint if it persist"));
		antenatalData.add(new AntenatalData("Constipation","It happens anytime during pregnancy. This is associated to pregnancy hormones soften your muscles and ligaments so they cannot move food through your intestines as quickly as usual. \nConstipation can also be from the pressure of the expanding uterus and sometimes from iron supplements. \nStraining due to constipation can also lead to growth of piles "));
		antenatalData.add(new AntenatalData("What to do?","-Drink atleast 8-10 glasses of water every day.\n-Do regular gentle exercise-Eat atleast five servings of fruit and vegetables everyday\n -Take high fibre foods i.e. whole grain varieties of cereals, bread pasta and rice.\n-Engage on this complaint with your doctor "));
		antenatalData.add(new AntenatalData("Piles Second three months","They are hemorrhoids are varicose veins in your back passage, caused by constipation, piles tend to occur from around the middle of pregnancy "));
		antenatalData.add(new AntenatalData("What to do?","Eat a lot of high fibre diet,Drink a lot of fluids, around 8-12 glasses dailyTake servings of a lot of fruits and vegetables in your dietEngage They are hemorrhoids are varicose veins in your back passage, caused by constipation, piles tend to occur from around the middle of pregnancy in regular exercise such as walkingEngage your doctor further on this complaint"));
		antenatalData.add(new AntenatalData("Stretch marks","This condition go hand in hand with weight gain, they are very common and affect between 75-90 percent of pregnant women and usually by the 6th or 7th month of pregnancy. They appear on stomach, thighs and breast region as the skin stretches. Messaging the skin with lotion can help prevent or reduce stretch marks developing at this stage. It's induced by the elastic supportive tissue that lies just beneath the skin."));
		antenatalData.add(new AntenatalData("What to do?","-Drink plenty of water, 8-10 glasses of water a day-Use regularly moisturisers and creams daily\n-Engage further on this complaint with your doctor"));
		antenatalData.add(new AntenatalData("Second three months Varicose","This are swollen veins that usually occur in the lower leg. This can be due to hereditary factors prolonged standing or advanced age"));
		antenatalData.add(new AntenatalData("What to do","-Inhibit crossing your legs when you are sitting\n-Incline and elevate your feet and legs whenever possible\n-Eliminate tight and restrictive clothing-Wear special support clothing \n-Discuss further this complaint with your doctor "));
		antenatalData.add(new AntenatalData("(iii)Last three months\nBack pain","It's very common during your pregnancy, especially in the later stages. This associated at times to change of posture as the baby grows and ligaments "));
		antenatalData.add(new AntenatalData("What to do?","-Good posture is vital, stand tall, shoulders relaxed, buttocks tucked in weight spread evenly on both feet\n-Ensure you put a pillow behind you while sited\n-Avoid lifting heavy objects\n-Take regular exercise\n-Sleep on a firm mattress\n-Avoid wearing high shoes or heels\n-Engage further your doctor in case this complaint persist"));
		antenatalData.add(new AntenatalData("Antenatal care classes","Employees are entitled to time off from work, without loss of pay for the purposes of receiving antenatal care/attending classes of pregnant employees An employee must inform her employer in writing of the time and date of the appointment not later than 2 weeks before the date of the appointment "));
		antenatalData.add(new AntenatalData("Antenatal craft classes","Also known as parent craft classes are offered to all women and either with their partners in the second half of pregnancy.\nAre designed to give parents or to be parent’s advice on various aspects of pregnancy and child care and boost their confidence as they prepare for parenthood.Classes held, often free of charge subject to healthcare providers, this is done by midwives, healthcare visitors or doctor either at your local hospital or other centres"));
		antenatalData.add(new AntenatalData("Areas of study covered in the classes","-Looking after your health during pregnancy\n-Growth and development of the baby during pregnancy\n-Labour and delivery options\n-Pain relief during labour\n-When to go into hospital-Timing pregnancy labour constrictions\n-Emotional aspects of becoming a parent\n-Breastfeeding support and advice \n-What to expect during labour-Physical care of your baby\n-Returning to work, childcare arrangements "));
		antenatalData.add(new AntenatalData("Leave and benefits","All pregnant women employees are entitled to maternity leave, this vary from one organization to another in regards to the kind of benefits she’s entitled to.According to section 29 of employment act, 2007 provide that a female employee shall be entitled to maternity leave on full pay if she gives not less than seven days written notice in advance or a shorter period as may be reasonable in the circumstances of her intention to proceed on leave. She is entitled to three months maternity leave in addition to any period of leave if she happens to fall ill during the confinement and with the consent of employer. "));
		antenatalData.add(new AntenatalData("Baby registration","Every parent is required to register is baby at the registrar of births and issued with a birth certificate within a specific period.\n She’s required to provide supporting documents for the same such as birth notification forms issued at the hospital, midwife letter of approval and local administration letter of approval.\nYou will need a birth certificate to enroll your child in school, to apply for a passport and many other purposes. The birth certificate will contain the information on the child and the parents that is given at the time of registration, so it is important that the information given is accurate. \nIt is difficult to change the details after initial registration. If the parents are unmarried the father must consent to have his details included."));
		antenatalData.add(new AntenatalData("Birth plan ","Keeping a diary of the way events you would like them unfolds for your birth, whether medications, no drugs or anything in between.\n Outlining your preferences allows your doctors, nurses and midwives know how best to help you in labour and after the birth.\nBe realistic and flexible when drafting a birth plan, don’t be disappointed if things don’t go exactly as planned – they rarely do.\n As you write your birth plan, please consider?\n-Your care provider preference?\n-Where would you like your baby born?\n-Who you want in the delivery room? \n-Birthing equipment you might prefer?\n-What pain medications if any, you would prefer?\n-Consider either your baby has a pacifier and let the hospital staff know?\nWhat induction techniques you would prefer if it’s required?\n-Any feeling about assisted delivery such as the use of forceps? \n-Any wishes for the first moments after birth such as cutting of the umbilical cord? \n-Your feelings on initiation of breastfeeding or formula feed? \n-If you need a caesarean, do you have any special requests?\n-How do you feel about foetal monitoring?\n-I prefer to have no vaginal exams until I go into labour?"));
		antenatalData.add(new AntenatalData("Areas of study covered in the classes","-Looking after your health during pregnancy\n -Growth and development of the baby during pregnancy \n-Labour and delivery options\n -Pain relief during labour -When to go into hospital\n-Timing pregnancy labour constrictions-Emotional aspects of becoming a parent\n-Breastfeeding support and advice  \n-What to expect during labour-Physical care of your baby\n-Returning to work, childcare arrangements "));
		antenatalData.add(new AntenatalData("Your hospital stay","After birth delivery, most women prefer to hold their babies straight from the womb.If you have had a straight forward vaginal birth, you and your baby could be at home within hours. If you have a caesarean you can normally expect in hospital for 3-4 days. A longer stay is only necessary if you, or your baby are on well.Midwives can show you how to hold your baby, clean her/him and how to care for her umbilical cord stump. At some hospitals you may also be shown how to bath your baby. In some instance you may worry to go to the loo without your partner being there and leave your baby alone there. In some units there is room for you to wheel your baby’s cot into the bathroom, or seek a midwife or care assistant to watch your baby while you are gone.Before due date you should have your bag well prepared and it will give you a peace of mind. Avoid over packing, since most hospital rooms are small you don’t need the extra clutter, try to keep everything in one bag or suitcase. "));
		antenatalData.add(new AntenatalData("BELOW ARE STAGES FOR YOUR JOURNEY TO DELIVERY\nLuggage for the labour ward","-Comfortable t-shirts/night dress\n-Towel/face cloth\n-Socks/slippers\n-Dressing/hospital gown\n-Face wipes, water spray \n-Lip balm \n-Tooth brush/toothpaste \n-Camera \n-Disposable pants \n-Watch for timing contractors \n-Birth plan \n-Maybe some sandwiched/snacks for after the birth as very often hospital facilities maybe closed"));
		antenatalData.add(new AntenatalData("Luggage for your hospital stay","-Hospital notes\n-Nursing bras\n -Phone charger\n-Breast pads\n -Maternity pads \n-Toiletries/deodorant\n -Bath robe \n-Dark coloured towel \n-Going home outfit \n-Loose fitting  \n-Front opening night dress for breast feeding"));	
		antenatalData.add(new AntenatalData("Your new born needs at the hospital\nLuggage for babies","Vest, baby diapers, cellular blankets, towels new born nappies (plenty) barner clean, cotton wool, bibsYour new born baby need on route home  Cardigan, outfit for going home, car seat (your baby must travel in a correct seat when leaving hospital), sun hot for going out when hot.Choose the right car seat, make sure you get help installing the car seat, make sure the car seat has a manual for instructions with manufacturer date and model numbers make sure also its not more than six years, has no visible damage or missing parts or has never been in a moderate or fatal crush. Arrange childcare for other siblings, set-up home delivery account for grocery and supermarket."));
		antenatalData.add(new AntenatalData("Your baby name","It helps you select the perfect baby name in respect to the date of birth and other factors."));
		antenatalData.add(new AntenatalData("Baby`s hospital card","Name, Date of birth, weight, head size, charts, hospital name, next hospital visit, purpose of hospital visit, if any drugs given list them, blood group (mother + baby)Update baby’s information as weight, height, frequency of hospital visits Doctor/midwife names from birth to present Amount of money spend on every hospital visit Nanny’s name/ID number/Telephone number"));
		antenatalData.add(new AntenatalData("Prenatal tests","Prenatal tests can help identity health problems that could endanger both a woman and her unborn, child, some of which are treatable. However there tests do have limitations. As an expectant parent, it’s vital to educate yourself about them and to think about what you would do if a health problem was detected."));
		antenatalData.add(new AntenatalData("Test in a mother","Her blood type Whether she has gestational diabetes, anaemia or other health conditions.Her immunity to certain diseases Whether she has cervical cancer or STD"));
		antenatalData.add(new AntenatalData("Test in a developing child","Treatable health conditions that can affect the baby’s healthy characteristics i.e size, sex, age and placement in the uterus.Chance the baby has a certain birth defect or genetic problems.Certain types of fetal abnormalities. i.e. heart problems."));
		antenatalData.add(new AntenatalData("Other routine tests for certain women especially high risk pregnancy. This may include ","Age 35 and above Are adolescents.  Have had a premature baby. Have had a baby with birth defect or genetic problems.Are carrying more than one baby.Have high blood pressure, diabetes, heart disease, kidney problems, and cancer, STDs, asthma or seizure disorders.Have a genetic disorders family history or a partner who does.Have a family history of mental retardation or partner who does."));
		antenatalData.add(new AntenatalData("How can I have a healthy pregnancy?","-Avoid smoking even second hand \n-Avoid alcohol and other drugs\n-Checking with doctor about safety of prescription and over the counter, medications. \n-Avoiding founts, chemicals, radiation and excessive heat.\n -Eating healthy diet. \n-Taking prenatal vitamins ` if possible, even before becoming pregnant.\n-Getting exercise and active after discussing with your doctor.\n-Getting plenty of rest.\n-Getting prenatal care."));
		antenatalData.add(new AntenatalData("Some of the pregnancy tests. \nChorionic villus sampling (CVS)","Used for identifying chromosomes abnormalities and other inherited disorders "));
		antenatalData.add(new AntenatalData("Urinalysis","Screening for pregnancy as part of your prenatal care."));
		antenatalData.add(new AntenatalData("Ultrasound","scan Used to scan a woman`s abdomen and pelvic cavity creating a picture (sonogram) of the baby and placenta, check baby's heart beat, check and detect multiple pregnancy, determine the position of the baby and check the amniotic fluid around the baby. "));
		antenatalData.add(new AntenatalData("Glucose tolerance test","Is a common test for potential gestational diabetes, this diabetes can cause risk to both mother and child and is brought about by pregnancy."));
		antenatalData.add(new AntenatalData("Biophysical profile ","Combines an ultrasound evaluation with a non-stress test and is intended to determine fetal health. "));
		antenatalData.add(new AntenatalData("Quad screen","Is a maternal blood screening test that looks for four specific substances."));
		antenatalData.add(new AntenatalData("Amniocentesis","A diagnostic test, recommended by your healthcare provider due to an abnormal triple test results, it`s normal a inheriting or genetic concerns that parents may subscribe to it."));
		antenatalData.add(new AntenatalData("Blood test","Tested to check, hemoglobin levels, iron levels, glucose levels, R+ factor, blood type, sexually transmitted disease. "));
		antenatalData.add(new AntenatalData("Alpha-fetoprotein test ","Most women can expect to get AFP testing during their pregnancy, if is a blood test that can indicate an increased risk of fetal neural tube defects, it also indicate increased risk of down syndrome. "));
		antenatalData.add(new AntenatalData("DNA test","used to establish paternity of the unborn especially when the mother had more than two sexual partners. "));
		antenatalData.add(new AntenatalData("Pregnancy diet","A healthy diet is key during pregnancy such as carbohydrates, fats, vitamins, mineral and plenty of water. Food labels can tell you the kind of food you are consuming. The following are the most vital nutrients you need and the food composition as:- "));

		
		
		
		
		dialog.dismiss();
		ShowNext(null);
	}

	public void ShowNext(View view){
		
		if(AmAtPage < antenatalData.size()-1){
			AmAtPage++;
			((TextView)findViewById(R.id.pageat)).setText((AmAtPage+1)+" of "+antenatalData.size());
			((TextView)findViewById(R.id.header)).setText(antenatalData.get(AmAtPage).getHeader());
			((TextView)findViewById(R.id.description)).setText(antenatalData.get(AmAtPage).getDescription());
		
		}
		else {
			Toast.makeText(this, "This is the last page", Toast.LENGTH_LONG).show();
		}
		}
	public void ShowPrevius(View view){
		
		if(AmAtPage >0){
			AmAtPage--;
			((TextView)findViewById(R.id.pageat)).setText((AmAtPage+1)+" of "+antenatalData.size());
		((TextView)findViewById(R.id.header)).setText(antenatalData.get(AmAtPage).getHeader());
		((TextView)findViewById(R.id.description)).setText(antenatalData.get(AmAtPage).getDescription());
		
		}
		else {
			Toast.makeText(this, "This is the first page", Toast.LENGTH_LONG).show();
		}
		}
	public void Share(View view){
		Intent intent = new Intent(Intent.ACTION_SEND);
		intent.setType("text/plain");
		intent.setPackage("com.whatsapp");
		intent.putExtra(Intent.EXTRA_TEXT, antenatalData.get(AmAtPage).getDescription()+"");
		try{
		startActivity(intent);
		}catch (Exception e) {
			// TODO: handle exception
			Toast.makeText(this, "Hey download whatsapp", Toast.LENGTH_LONG).show();
		}
	}
	
	
}

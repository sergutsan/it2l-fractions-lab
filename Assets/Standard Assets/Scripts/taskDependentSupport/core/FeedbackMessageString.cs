using System;
namespace taskDependentSupport.core
{
	 class FeedbackMessageString
	{
		private static int startNumerator = 0;
		private static int endNumerator = 0;
		private static int startDenominator = 0;
		private static int endDenominator = 0;
		private static String representation = "area";
		private bool english = true;
		private bool german  =false;
		private bool spanish = false;

		 String fS1M_socratic = "How are you going to tackle this task?";
		 String fS1M_didacticConceptual = "Read the task again, and explain how you are going to tackle it.";

		 String fS2M_socratic = "What do you need to do in this task?";
		 String fS2M_guidance = "You can click one of the buttons on the representations toolbox to create a fraction.";
		 String fS2M_didacticConceptual ="Read the task again, and explain how you are going to tackle it.";

		 String fS3M_socratic = "Good. What do you need to do now, to change the fraction?";
		 String fS3M_guidance = "You can use the arrow buttons to change the fraction.";
		 String fS3M_didacticConceptual = "Now click the up arrow next to the empty fraction, to make the denominator.";
		 String fS3M_didacticProcedural = "Click the up arrow next to the empty fraction, to make the denominator (the bottom part of the fraction) "+endDenominator+".";

		 String fM1M_socratic = "Is the denominator in your fraction correct?";
		 String fM1M_guidance = "You can click the up arrow next to your fraction to change the denominator.";
		 String fM1M_didacticConceptual = "Check that the denominator in your fraction is correct.";
		 private String fM1M_didacticProcedural = "Check that the denominator (the bottom part of your fraction) is "+endDenominator+".";

		 String fM2M_socratic = "Have you changed the numerator or the denominator?";
		 String fM2M_guidance = "Remember that the denominator is the bottom part of the fraction.";
		 String fM2M_didacticConceptual = "Check that you have changed the denominator, not the numerator.";
		 String fM2M_didacticProcedural = "Check that the denominator in your fraction, not the numerator, is "+endDenominator+".";

		 String fCM2M_socratic  = "Have you changed the numerator or the denominator?";
		 String fCM2M_guidance = "Remember that the denominator is the bottom part of the fraction.";
		 String fCM2M_didacticConceptual = "Check that you have changed the denominator, not the numerator.";
		 String fCM2M_didacticProcedural = "Check that the denominator in your fraction, not the numerator, is "+endDenominator+".";

		 String fM3M_socratic = "Is this the fraction you were planning to make?";
		 String fM3M_guidance = "Please read the task again carefully.";
		 String fM3M_didacticConceptual = "Re-read the task then echeck your fraction.";

		 String fM4M_didacticConceptual = "Excellent. Please explain what the numerator and denominator are.";

		 String fM5M_socratic = "Have you changed the denominator or the numerator?";
		 String fM5M_guidance = "The denominator is the bottom part of the fraction.";
		 String fM5M_didacticConceptual = "You changed the numerator. You need to change the denominator.";
		 String fM5M_didacticProcedural = "You changed the numerator. You need to change the denominator to "+endDenominator+".";

		 String fCM5M_socratic = "Have you changed the denominator or the numerator?";
		 String fCM5M_guidance = "The denominator is the bottom part of the fraction.";
		 String fCM5M_didacticConceptual = "You changed the numerator. You need to change the denominator.";
		 String fCM5M_didacticProcedural = "You changed the numerator. You need to change the denominator to "+endDenominator+".";

		 String fM6M_socratic = "Excellent. Now, how are you going to change the numerator?";
		 String fM6M_guidance = "If you click near the top of your fraction, and click the arrow, you can change the numerator (the top part of the fraction).";
		 String fM6M_didacticConceptual = "You changed the denominator. Now, change the numerator.";
		 String fM6M_didacticProcedural = "Now, change the numerator. Remember, you need to make the fraction equivalent to "+startNumerator+"/"+startDenominator+".";

		 String fCM6M_socratic = "Excellent. Now, how are you going to compare the fraction?";
		 String fCM6M_guidance = "Now that you have made the first fraction, you need to compare it with the second fraction.";
		 String fCM6M_didacticConceptual = "You now need to compare the fraction with a second fraction.";
		 String fCM6M_didacticProcedural = "Now, create a second fraction using the same representation.";

		 String fCM6MSecond_socratic = "Excellent. Now, how are you going to compare the fraction?";
		 String fCM6MSecond_guidance = "Now that you have made the first fraction, you need to compare it with the second fraction.";
		 String fCM6MSecond_didacticConceptual = "You now need to compare the fraction with a second fraction.";
		 String fCM6MSecond_didacticProcedural = "Now, create a second fraction using the same representation.";

		 String fM7M_socratic = "Excellent. How are you going to make the equivalent fraction?";
		 String fM7M_guidance = "You could now copy the fraction and use `find equivalent' to make an equivalent fraction. Right-click the fraction.";
		 String fM7M_didacticConceptual = "Excellent. Now copy this fraction, right click the copy, and select `find equivalent'.";
		 String fM7M_didacticProcedural = "Excellent. Now copy this fraction, right click the copy, and select `find equivalent' to make a fraction with a denominator of "+endDenominator+".";

		 String fCM7M_socratic = "Why have you decided to use a different representation? What does the task ask you to do?";
		 String fCM7M_guidance = "Please use the same representation for the second fraction.";
		 String fCM7M_didacticProcedural = "Please create the second fraction using the same representation that you used for the first fraction.";

		 String fM8M_socratic = "Now that you have made "+endNumerator+"/"+endDenominator+" how are you going to compare it with "+startNumerator+"/"+startDenominator+"?";
		 String fM8M_guidance = "Look at the task and think about what other fraction you need to make to compare it with "+endNumerator+"/"+endDenominator+".";
		 String fM8M_didacticConceptual = "You need one of your fractions to be "+startNumerator+"/"+startDenominator+", to compare it with "+endNumerator+"/"+endDenominator+".";
		 String fM8M_didacticProcedural = "Keep the fraction "+endNumerator+"/"+endDenominator+". Now change the other fraction to "+startNumerator+"/"+startDenominator+". Then compare the two fractions using the comparison box.";

		 String fM9M_socratic = "How are you going to make a fraction with the denominator "+endDenominator+", that is equivalent to "+startNumerator+"/"+startDenominator+".";
		 String fM9M_guidance = "Look at the task and think about what other fraction you need to make to compare it with "+startNumerator+"/"+startDenominator+".";
		 String fM9M_didacticConceptual = "As well as "+startNumerator+"/"+startDenominator+", you need a second fraction that is equivalent to "+startNumerator+"/"+startDenominator+" and that has "+endDenominator+" as its denominator.";
		 String fM9M_didacticProcedural = "Keep the fraction "+startNumerator+"/"+startDenominator+". Now change the other fraction to "+endNumerator+"/"+endDenominator+". Then compare the two fractions using the comparison box.";

		 String fM10M_socratic = "How could you compare your fraction with "+startNumerator+"/"+startDenominator+"?";
		 String fM10M_guidance = "Think about the denominators in the two fractions. What is the relationship between them?";
		 String fM10M_didacticConceptual = "Compare your fraction with "+startNumerator+"/"+startDenominator+"  by creating another fraction, this time "+startNumerator+"/"+startDenominator+", and using the comparison box.";

		 String fCM8M_socratic = "Excellent. How using the comparison tool to compare the two fractions?";
		 String fCM8M_guidance = "You could now compare the fractions. Open the comparison tool at the top of the screen.";
		 String fCM8M_didacticConceptual = "Excellent. Now use the comparison tool.";
		 String fCM8M_didacticProcedural = "Excellent. Not open the comparison tool, at the top of the screen, and drag in the two fractions.";

		 String fM11M_socratic = "What are you going to compare your fraction with?";
		 String fM11M_guidance = "In equivalent fractions, the two numerators must be the same multiple of each other as the two denominators.";
		 String fM11M_didacticConceptual = "First create another fraction, this time "+startNumerator+"/"+startDenominator+". Then compare your two fractions.";

		 String fM12M_didacticConceptual = "Excellent. Please explain why you made the denominator "+endDenominator+".";

		 String fM13M_socratic = "How can you check, using a Fractions Lab tool, that your solution is correct?";
		 String fM13M_guidance = "You could use the comparison box to compare your fractions.";
		 String fM13M_didacticConceptual = "Compare the two fractions using the comparison box.";

		 String fCM11M_didacticConceptual = "Excellent. Please explain why you made the denominator 3.";

		 String fCM12M_socratic = "Excellent, what are you going to do now?";

		 String fE1M_didacticConceptual = "The way that you worked that out was excellent. Well done.";

		 String fE2M_didacticConceptual = "Please explain what you did to the numerator and the denominator of "+startNumerator+"/"+startDenominator+" to make an equivalent fraction with "+endDenominator+" as the denominator.";

		 String fCE2M_didacticConceptual = "Please explain what you found by comparing 1/3 and 1/5.";

		 String fR1M_didacticConceptual = "What has happened to the numerator and denominator? Have they been affected the same or differently?";

		 String fR2M_didacticConceptual = "Why did you make the fraction "+endNumerator+"/"+endDenominator+"? What did you do to the numerator and denominator of "+startNumerator+"/"+startDenominator+"?";

		 String fO1M_didacticConceptual = "You don't appear to have completed the task.";

		 String fO2M_didacticConceptual = "If you need more help to finish the task, you could ask your teacher.";

		 String fMF6M_socratic = "Excellent. Now, how are you going to use a different representation?";
		 String fMF6M_guidance = "Excellent, Now, click the representation toolbar and create another representation of exactly the same fraction.";

		 String fMF10M_socratic = "Excellent. How are your representations similar, and how are they different?";

		 String fMF11M_socratic = "Excellent! Have you completed the task?";
		 String fMF11M_guidance = "Excellent! Keep going. Now make your fraction using a different representation.";

		 String fMF12M_socratic = "Excellent! Do your fractions have the same values?";
		 String fMF12M_guidance = "Excellent! Now change your fractions to the same values.";

		 String fMFE1M_didacticConceptual = "Excellent, you have made your fraction using all the representations. Well done.";

		 String fMFE2M_didacticConceptual ="How are all your representations similar, and how are they different?";

		 String fF2M1M_socratic = "Good. What do you need to do now, to complete the fraction?";
		 String fF2M1M_guidance = "You can use the arrow buttons at the top of the fraction to complete your fraction.";
		 String fF2M1M_didacticConceptual = "Now click the up arrow next to the top of the fraction, to make the numerator.";
		 String fF2M1M_didacticProcedural = "Click the up arrow next to the top of the fraction, to make the numerator (the top part of the fraction).";

		 String fF2M4M_socratic = "Excellent. What fraction have you made?";

		 String fF2M6M_socratic = "Excellent. Now, how are you going to partition the fraction?";
		 String fF2M6M_guidance = "Right click the fraction, select `find equivalent', and partition the fraction into two.";
		 String fF2M6M_didacticConceptual = "Click the fraction with the right-hand mouse button, then select `find equivalent' and partition the fraction into two.";
		 String fF2M6M_didacticProcedural = "Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into two.";

		 String fF2M7M_socratic = "Excellent. Now, how are you going to partition the fraction into 3?";
		 String fF2M7M_guidance = "Right click the fraction, select `find equivalent', and partition the fraction into 3.";
		 String fF2M7M_didacticConceptual = "Click the fraction with the right-hand mouse button, then select `find equivalent', and partition the fraction into 3.";
		 String fF2M7M_didacticProcedural = "Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into 3.";

		 String fF2M7bM_socratic = "Excellent. Now, how are you going to partition the fraction into 4?";
		 String fF2M7bM_guidance = "Right click the fraction, select `find equivalent', and partition the fraction into 4.";
		 String fF2M7bM_didacticConceptual = "Click the fraction with the right-hand mouse button, then select `find equivalent', and partition the fraction into 4.";
		 String fF2M7bM_didacticProcedural = "Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into 4.";

		 String fF2M7cM_socratic = "Excellent. Now, how are you going to partition the fraction into 5?";
		 String fF2M7cM_guidance = "Right click the fraction, select `find equivalent', and partition the fraction into 5.";
		 String fF2M7cM_didacticConceptual = "Click the fraction with the right-hand mouse button, then select `find equivalent', and partition the fraction into 5.";
		 String fF2M7cM_didacticProcedural = "Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into 5.";

		 String fF2M10M_socratic = "Excellent. Is your new fraction equivalent to your original fraction? What has happened to the denominator and what has happened to the numerator?";

		 String fF2M11M_socratic = "Excellent! Have you completed the task?";
		 String fF2M11M_guidance = "Keep going. Now partition your fraction further.";

		 String fMF2E1M_didacticConceptual = "Excellent, you have partitioned your fraction 2, 3, 4 and 5 times. Well done.";

		 String fMF2E2M_didacticConceptual = "When you used find equivalent, what happened to the denominators and numerators?";


		 String fT24M1M_socratic = "Is the denominator in your fraction correct?";
		 String fT24M1M_guidance = "You can click the up arrow next to your fraction to change it.";
		 String fT24M1M_didacticConceptual = "Check that the denominator in your fraction is correct.";
		 String fT24M1M_didacticProcedural = "Check that the denominator (the bottom part of your fraction) is "+startDenominator+".";

		 String fT24M2M_socratic = "Have you changed the numerator or denominator?";
		 String fT24M2M_guidance = "Remember that the denominator is the bottom part of the fraction.";
		 String fT24M2M_didacticConceptual = "Check that you have changed the denominator, not the numerator.";
		 String fT24M2M_didacticProcedural = "Check that the denominator in your fraction, not the numerator, is "+startDenominator+".";

		 String fT24M3M_socratic = "Is this the fraction you were planning to make?";
		 String fT24M3M_guidance = "Please read the task again carefully.";
		 String fT24M3M_didacticConceptual = "Re-read the task then check your fraction.";

		 String fT24M4M_didacticConceptual = "Excellent. Please explain what the 'numerator' and `denominator' are";

		 String fT24M5M_socratic = "Have you changed the denominator or the numerator?";
		 String fT24M5M_guidance = "The denominator is the bottom part of the fraction.";
		 String fT24M5M_didacticConceptual = "You changed the numerator. You need to change the denominator.";
		 String fT24M5M_didacticProcedural = "You changed the numerator. You need to change the denominator to "+startDenominator+".";

		 String fT24M6M_socratic = "Excellent. Now, how are you going to change the numerator?";
		 String fT24M6M_guidance = "If you click near the top of your fraction, and click the up arrow, you can change the numerator (the top part of the fraction).";
		 String fT24M6M_didacticConceptual = "You changed the denominator. Now, change the numerator.";
		 String fT24M6M_didacticProcedural = "Now, change the numerator. Remember, you need to make a fraction equivalent to "+startNumerator+"/"+startDenominator+".";

		 String fT24M7M_socratic = "Excellent. How are you going to make an equivalent fraction?";
		 String fT24M7M_guidance = "You could now copy the fraction and use `find equivalent' to make an equivalent fraction.";
		 String fT24M7M_didacticConceptual = "Excellent. Now copy this fraction and use `find equivalent' to change it.";
		 String fT24M7M_didacticProcedural = "Excellent. Now right click the fraction and copy it. Then right click the copy and select `find equivalent' to make an equivalent fraction.";

		 String fT24M8M_socratic = "How could you compare your fraction with "+startNumerator+"/"+startDenominator+".";
		 String fT24M8M_guidance = "Think about the denominators in your fraction and in "+startNumerator+"/"+startDenominator+". What is the relationship between them? What do you need to do to "+startNumerator+" to work out the correct numerator for your fraction?";
		 String fT24M8M_didacticConceptual = "Compare your fraction with "+startNumerator+"/"+startDenominator+" by using the comparison box.";

		 String fT24M9M_socratic = "What are you going to compare your fraction with?";
		 String fT24M9M_guidance = "In equivalent fractions, the two numerators must be the same multiple of each other as the two denominators.";
		 String fT24M9M_didacticConceptual = "First create another fraction, this time "+startNumerator+"/"+startDenominator+". Then compare your two fractions.";

		 String fT24M10M_didacticConceptual = "Excellent. Please explain why you made the denominator "+startDenominator+" or a multiple of "+startDenominator+".";

		 String fT24M11M_socratic = "How can you check, using a Fractions Lab tool,  that your solution is correct?";
		 String fT24M11M_guidance = "You could use the comparison box to compare your fractions.";
		 String fT24M11M_didacticConceptual = "Compare the two fractions using the comparison box.";

		 String fT24M12M_socratic = "Now that you have made a fraction that is equivalent to "+startNumerator+"/"+startDenominator+", how are you going to compare it with "+startNumerator+"/"+startDenominator+"?";
		 String fT24M12M_guidance = "Look at the task and think about what other fraction you need to make, to compare with your fraction.";
		 String fT24M12M_didacticConceptual = "To compare your fraction to "+startNumerator+"/"+startDenominator+", you will need to make a second fraction, this time "+startNumerator+"/"+startDenominator+".";
		 String fT24M12M_didacticProcedural = "Keep the fraction that you have made. Now create a second fraction. This time "+startNumerator+"/"+startDenominator+". Then compare the two fractions using the comparison box.";

		 String fT24M13M_socratic = "Now that you have made a fraction that is equivalent to "+startNumerator+"/"+startDenominator+", how are you going to compare it with "+startNumerator+"/"+startDenominator+"?";
		 String fT24M13M_guidance = "Look at the task and think about what other fraction you need to make, to compare with your fraction.";
		 String fT24M13M_didacticConceptual = "To compare your fraction to "+startNumerator+"/"+startDenominator+", you will need to make a second fraction, this time "+startNumerator+"/"+startDenominator+".";
		 String fT24M13M_didacticProcedural = "Keep the fraction that is equivalent to "+startNumerator+"/"+startDenominator+". Now change the other fraction to "+startNumerator+"/"+startDenominator+". Then compare the two fractions using the comparison box.";

		 String fT24E1M_didacticConceptual = "The way that you worked that out was excellent. Well done.";

		 String fT24E2M_didacticConceptual = "Please explain what you did to the numerator and denominator of "+startNumerator+"/"+startDenominator+" to make an equivalent fraction.";



		 String fT26M1M_guidance = "You can click the up arrow next to your fraction to change it.";
		 String fT26M1M_socratic = "Is the denominator in your fraction correct?";
		 String fT26M1M_didacticConceptual = "Check that the denominator in your fraction is correct.";
		 String fT26M1M_didacticProcedural = "Check that the denominator (the bottom part of your fraction) is "+startDenominator+" or "+endDenominator+".";

		 String fT26M2M_guidance = "Remember that the denominator is the bottom part of the fraction.";
		 String fT26M2M_socratic = "Have you changed the numerator or denominator?";
		 String fT26M2M_didacticConceptual = "Check that you have changed the denominator, not the numerator.";
		 String fT26M2M_didacticProcedural = "Check that the denominator in your fraction, not the numerator, is "+startDenominator+" or "+endDenominator+".";

		 String fT26M3M_guidance = "Please read the task again carefully.";
		 String fT26M3M_socratic = "Is this the fraction you were planning to make?";
		 String fT26M3M_didacticConceptual = "Re-read the task then check your fraction.";

		 String fT26M4M_didacticConceptual = "Excellent. Please explain what the 'numerator' and `denominator' are.";

		 String fT26M5M_guidance = "The denominator is the bottom part of the fraction.";
		 String fT26M5M_socratic = "Have you changed the denominator or the numerator?";
		 String fT26M5M_didacticConceptual = "You changed the numerator. You need to change the denominator.";
		 String fT26M5M_didacticProcedural = "You changed the numerator. You need to change the denominator to "+startDenominator+" or "+endDenominator+".";

		 String fT26M6M_guidance = "If you click near the top of your fraction, and click the up arrow, you can change the numerator (the top part of the fraction).";
		 String fT26M6M_socratic = "Excellent. Now, how are you going to change the numerator?";
		 String fT26M6M_didacticConceptual = "You changed the denominator.  Now, change the numerator.";
		 String fT26M6M_didacticProcedural = "Now, change the numerator. Remember, you need to make the fraction "+startNumerator+"/"+startDenominator+" or "+endNumerator+"/"+endDenominator+".";

		 String fT26M7M_guidance = "There are two fractions in this task.  You can make another fraction by using the representation tool.";
		 String fT26M7M_socratic = "Excellent. How are you going to make the second fraction?";
		 String fT26M7M_didacticConceptual = "Please make the other fraction.";
		 String fT26M7M_didacticProcedural = "You have made "+startNumerator+"/"+startDenominator+" or "+endNumerator+"/"+endDenominator+".  Please make "+startNumerator+"/"+startDenominator+" or "+endNumerator+"/"+endDenominator+".";

		 String fT26M8M_guidance = "It is easier to compare fractions when they are represented the same way.";
		 String fT26M8M_socratic = "Can you think of a clearer way to represent the fractions?";
		 String fT26M8M_didacticConceptual = "Please change one of your fractions so they use the same representation.";

		 String fT26M10M_didacticConceptual = "Great. Please explain why you made these fractions.";

		 String fT26M11M_guidance = "You could use the comparison box to compare your fractions.";
		 String fT26M11M_socratic = "How can you check, using a Fractions Lab tool,  that your solution is correct?";
		 String fT26M11M_didacticConceptual = "Compare the two fractions using the comparison box.";

		 String fT26E1M_didacticConceptual = "The way that you worked that out was excellent. Well done.";

		 String fT26E2M_didacticConceptual = "Please explain why you agree or disagree.";



		 String fT3aP1M1M_socratic = "Is the denominator in your fraction correct?";
		 String fT3aP1M1M_guidance = "You can click the up arrow next to your fraction to change it.";
		 String fT3aP1M1M_didacticConceptual = "Check that the denominator in your fraction is correct.";
		 String fT3aP1M1M_didacticProcedural = "Check that the denominator (the bottom part of your fraction) is "+startDenominator+".";

		 String fT3aP1M2M_socratic = "Have you changed the numerator or denominator?";
		 String fT3aP1M2M_guidance = "Remember that the denominator is the bottom part of the fraction.";
		 String fT3aP1M2M_didacticConceptual = "Check that you have changed the denominator, not the numerator.";
		 String fT3aP1M2M_didacticProcedural = "Check that the denominator in your fraction, not the numerator, is "+startDenominator+".";

		 String fT3aP1M3M_socratic = "Is this the fraction you were planning to make?";
		 String fT3aP1M3M_guidance = "Please read the task again carefully.";
		 String fT3aP1M3M_didacticConceptual = "Re-read the task then check your fraction.";

		 String fT3aP1M4M_didacticConceptual = "Excellent. Please explain what the 'numerator' and `denominator' are.";

		 String fT3aP1M5M_socratic = "Have you changed the denominator or the numerator?";
		 String fT3aP1M5M_guidance = "The denominator is the bottom part of the fraction.";
		 String fT3aP1M5M_didacticConceptual = "You changed the numerator. You need to change the denominator.";
		 String fT3aP1M5M_didacticProcedural = "You changed the numerator. You need to change the denominator to "+startDenominator+".";

		 String fT3aP1M6M_socratic = "Excellent. Now, how are you going to change the numerator?";
		 String fT3aP1M6M_guidance = "If you click near the top of your fraction, and click the up arrow, you can change the numerator (the top part of the fraction).";
		 String fT3aP1M6M_didacticConceptual = "You changed the denominator.  Now, change the numerator.";
		 String fT3aP1M6M_didacticProcedural = "Now, change the numerator. Remember, you need to make two fractions that can be added together to make "+startNumerator+"/"+startDenominator+".";

		 String fT3aP1M7M_socratic = "Excellent. You've made one fraction. What do you need to do now, to complete the task?";
		 String fT3aP1M7M_guidance = "You now need to make a second fraction that, when added together with your first fraction, makes the fraction shown in the task.";

		 String fT3aP1M8M_socratic = "Think about how you add two fractions together. What needs to be the same, and what do you need to add together?";
		 String fT3aP1M8M_guidance = "To add two fractions together, the denominators need to be the same. Then you add together the numerators.";

		 String fT3aP1M10M_didacticConceptual = "Excellent. Please explain why you made the denominator "+startDenominator+".";

		 String fT3aP1M11M_socratic = "How can you check, using a Fractions Lab tool,  that your solution is correct?";
		 String fT3aP1M11M_guidance = "You could use the addition box to add your fractions.";
		 String fT3aP1M11M_didacticConceptual = "Add your two fractions using the addition box.";
	
		 String fT3aP1E1M_didacticConceptual = "The way that you worked that out was excellent. Well done.";

		 String fT3aP1E2M_didacticConceptual = "Please explain how you answered the task. Why did you make the fractions that you made?.";

		String gfS1M_socratic = "GERMAN How are you going to tackle this task?";
		String gfS1M_didacticConceptual = "GERMAN Read the task again, and explain how you are going to tackle it.";
		
		String gfS2M_socratic = "GERMAN What do you need to do in this task?";
		String gfS2M_guidance = "GERMAN You can click one of the buttons on the representations toolbox to create a fraction.";
		String gfS2M_didacticConceptual ="GERMAN Read the task again, and explain how you are going to tackle it.";
		
		String gfS3M_socratic = "GERMAN Good. What do you need to do now, to change the fraction?";
		String gfS3M_guidance = "GERMAN You can use the arrow buttons to change the fraction.";
		String gfS3M_didacticConceptual = "GERMAN Now click the up arrow next to the empty fraction, to make the denominator.";
		String gfS3M_didacticProcedural = "GERMAN Click the up arrow next to the empty fraction, to make the denominator (the bottom part of the fraction) "+endDenominator+".";
		
		String gfM1M_socratic = "GERMAN Is the denominator in your fraction correct?";
		String gfM1M_guidance = "GERMAN You can click the up arrow next to your fraction to change the denominator.";
		String gfM1M_didacticConceptual = "GERMAN Check that the denominator in your fraction is correct.";
		String gfM1M_didacticProcedural = "GERMAN Check that the denominator (the bottom part of your fraction) is "+endDenominator+".";
		
		String gfM2M_socratic = "GERMAN Have you changed the numerator or the denominator?";
		String gfM2M_guidance = "GERMAN Remember that the denominator is the bottom part of the fraction.";
		String gfM2M_didacticConceptual = "GERMAN Check that you have changed the denominator, not the numerator.";
		String gfM2M_didacticProcedural = "GERMAN Check that the denominator in your fraction, not the numerator, is "+endDenominator+".";
		
		String gfCM2M_socratic  = "GERMAN Have you changed the numerator or the denominator?";
		String gfCM2M_guidance = "GERMAN Remember that the denominator is the bottom part of the fraction.";
		String gfCM2M_didacticConceptual = "GERMAN Check that you have changed the denominator, not the numerator.";
		String gfCM2M_didacticProcedural = "GERMAN Check that the denominator in your fraction, not the numerator, is "+endDenominator+".";
		
		String gfM3M_socratic = "GERMAN Is this the fraction you were planning to make?";
		String gfM3M_guidance = "GERMAN Please read the task again carefully.";
		String gfM3M_didacticConceptual = "GERMAN Re-read the task then echeck your fraction.";
		
		String gfM4M_didacticConceptual = "GERMAN Excellent. Please explain what the numerator and denominator are.";
		
		String gfM5M_socratic = "GERMAN Have you changed the denominator or the numerator?";
		String gfM5M_guidance = "GERMAN The denominator is the bottom part of the fraction.";
		String gfM5M_didacticConceptual = "GERMAN You changed the numerator. You need to change the denominator.";
		String gfM5M_didacticProcedural = "GERMAN You changed the numerator. You need to change the denominator to "+endDenominator+".";
		
		String gfCM5M_socratic = "GERMAN Have you changed the denominator or the numerator?";
		String gfCM5M_guidance = "GERMAN The denominator is the bottom part of the fraction.";
		String gfCM5M_didacticConceptual = "GERMAN You changed the numerator. You need to change the denominator.";
		String gfCM5M_didacticProcedural = "GERMAN You changed the numerator. You need to change the denominator to "+endDenominator+".";
		
		String gfM6M_socratic = "GERMAN Excellent. Now, how are you going to change the numerator?";
		String gfM6M_guidance = "GERMAN If you click near the top of your fraction, and click the arrow, you can change the numerator (the top part of the fraction).";
		String gfM6M_didacticConceptual = "GERMAN You changed the denominator. Now, change the numerator.";
		String gfM6M_didacticProcedural = "GERMAN Now, change the numerator. Remember, you need to make the fraction equivalent to "+startNumerator+"/"+startDenominator+".";
		
		String gfCM6M_socratic = "GERMAN Excellent. Now, how are you going to compare the fraction?";
		String gfCM6M_guidance = "GERMAN Now that you have made the first fraction, you need to compare it with the second fraction.";
		String gfCM6M_didacticConceptual = "GERMAN You now need to compare the fraction with a second fraction.";
		String gfCM6M_didacticProcedural = "GERMAN Now, create a second fraction using the same representation.";
		
		String gfCM6MSecond_socratic = "GERMAN Excellent. Now, how are you going to compare the fraction?";
		String gfCM6MSecond_guidance = "GERMAN Now that you have made the first fraction, you need to compare it with the second fraction.";
		String gfCM6MSecond_didacticConceptual = "GERMAN You now need to compare the fraction with a second fraction.";
		String gfCM6MSecond_didacticProcedural = "GERMAN Now, create a second fraction using the same representation.";
		
		String gfM7M_socratic = "GERMAN Excellent. How are you going to make the equivalent fraction?";
		String gfM7M_guidance = "GERMAN You could now copy the fraction and use `find equivalent' to make an equivalent fraction. Right-click the fraction.";
		String gfM7M_didacticConceptual = "GERMAN Excellent. Now copy this fraction, right click the copy, and select `find equivalent'.";
		String gfM7M_didacticProcedural = "GERMAN Excellent. Now copy this fraction, right click the copy, and select `find equivalent' to make a fraction with a denominator of "+endDenominator+".";
		
		String gfCM7M_socratic = "GERMAN Why have you decided to use a different representation? What does the task ask you to do?";
		String gfCM7M_guidance = "GERMAN Please use the same representation for the second fraction.";
		String gfCM7M_didacticProcedural = "GERMAN Please create the second fraction using the same representation that you used for the first fraction.";
		
		String gfM8M_socratic = "GERMAN Now that you have made "+endNumerator+"/"+endDenominator+" how are you going to compare it with "+startNumerator+"/"+startDenominator+"?";
		String gfM8M_guidance = "GERMAN Look at the task and think about what other fraction you need to make to compare it with "+endNumerator+"/"+endDenominator+".";
		String gfM8M_didacticConceptual = "GERMAN You need one of your fractions to be "+startNumerator+"/"+startDenominator+", to compare it with "+endNumerator+"/"+endDenominator+".";
		String gfM8M_didacticProcedural = "GERMAN Keep the fraction "+endNumerator+"/"+endDenominator+". Now change the other fraction to "+startNumerator+"/"+startDenominator+". Then compare the two fractions using the comparison box.";
		
		String gfM9M_socratic = "GERMAN How are you going to make a fraction with the denominator "+endDenominator+", that is equivalent to "+startNumerator+"/"+startDenominator+".";
		String gfM9M_guidance = "GERMAN Look at the task and think about what other fraction you need to make to compare it with "+startNumerator+"/"+startDenominator+".";
		String gfM9M_didacticConceptual = "GERMAN As well as "+startNumerator+"/"+startDenominator+", you need a second fraction that is equivalent to "+startNumerator+"/"+startDenominator+" and that has "+endDenominator+" as its denominator.";
		String gfM9M_didacticProcedural = "GERMAN Keep the fraction "+startNumerator+"/"+startDenominator+". Now change the other fraction to "+endNumerator+"/"+endDenominator+". Then compare the two fractions using the comparison box.";
		
		String gfM10M_socratic = "GERMAN How could you compare your fraction with "+startNumerator+"/"+startDenominator+"?";
		String gfM10M_guidance = "GERMAN Think about the denominators in the two fractions. What is the relationship between them?";
		String gfM10M_didacticConceptual = "GERMAN Compare your fraction with "+startNumerator+"/"+startDenominator+"  by creating another fraction, this time "+startNumerator+"/"+startDenominator+", and using the comparison box.";
		
		String gfCM8M_socratic = "GERMAN Excellent. How using the comparison tool to compare the two fractions?";
		String gfCM8M_guidance = "GERMAN You could now compare the fractions. Open the comparison tool at the top of the screen.";
		String gfCM8M_didacticConceptual = "GERMAN Excellent. Now use the comparison tool.";
		String gfCM8M_didacticProcedural = "GERMAN Excellent. Not open the comparison tool, at the top of the screen, and drag in the two fractions.";
		
		String gfM11M_socratic = "GERMAN What are you going to compare your fraction with?";
		String gfM11M_guidance = "GERMAN In equivalent fractions, the two numerators must be the same multiple of each other as the two denominators.";
		String gfM11M_didacticConceptual = "GERMAN First create another fraction, this time "+startNumerator+"/"+startDenominator+". Then compare your two fractions.";
		
		String gfM12M_didacticConceptual = "GERMAN Excellent. Please explain why you made the denominator "+endDenominator+".";
		
		String gfM13M_socratic = "GERMAN How can you check, using a Fractions Lab tool, that your solution is correct?";
		String gfM13M_guidance = "GERMAN You could use the comparison box to compare your fractions.";
		String gfM13M_didacticConceptual = "GERMAN Compare the two fractions using the comparison box.";
		
		String gfCM11M_didacticConceptual = "GERMAN Excellent. Please explain why you made the denominator 3.";
		
		String gfCM12M_socratic = "GERMAN Excellent, what are you going to do now?";
		
		String gfE1M_didacticConceptual = "GERMAN The way that you worked that out was excellent. Well done.";
		
		String gfE2M_didacticConceptual = "GERMAN Please explain what you did to the numerator and the denominator of "+startNumerator+"/"+startDenominator+" to make an equivalent fraction with "+endDenominator+" as the denominator.";
		
		String gfCE2M_didacticConceptual = "GERMAN Please explain what you found by comparing 1/3 and 1/5.";
		
		String gfR1M_didacticConceptual = "GERMAN What has happened to the numerator and denominator? Have they been affected the same or differently?";
		
		String gfR2M_didacticConceptual = "GERMAN Why did you make the fraction "+endNumerator+"/"+endDenominator+"? What did you do to the numerator and denominator of "+startNumerator+"/"+startDenominator+"?";
		
		String gfO1M_didacticConceptual = "GERMAN You don't appear to have completed the task.";
		
		String gfO2M_didacticConceptual = "GERMAN If you need more help to finish the task, you could ask your teacher.";
		
		String gfMF6M_socratic = "GERMAN Excellent. Now, how are you going to use a different representation?";
		String gfMF6M_guidance = "GERMAN Excellent, Now, click the representation toolbar and create another representation of exactly the same fraction.";
		
		String gfMF10M_socratic = "GERMAN Excellent. How are your representations similar, and how are they different?";
		
		String gfMF11M_socratic = "GERMAN Excellent! Have you completed the task?";
		String gfMF11M_guidance = "GERMAN Excellent! Keep going. Now make your fraction using a different representation.";
		
		String gfMF12M_socratic = "GERMAN Excellent! Do your fractions have the same values?";
		String gfMF12M_guidance = "GERMAN Excellent! Now change your fractions to the same values.";
		
		String gfMFE1M_didacticConceptual = "GERMAN Excellent, you have made your fraction using all the representations. Well done.";
		
		String gfMFE2M_didacticConceptual ="GERMAN How are all your representations similar, and how are they different?";
		
		String gfF2M1M_socratic = "GERMAN Good. What do you need to do now, to complete the fraction?";
		String gfF2M1M_guidance = "GERMAN You can use the arrow buttons at the top of the fraction to complete your fraction.";
		String gfF2M1M_didacticConceptual = "GERMAN Now click the up arrow next to the top of the fraction, to make the numerator.";
		String gfF2M1M_didacticProcedural = "GERMAN Click the up arrow next to the top of the fraction, to make the numerator (the top part of the fraction).";
		
		String gfF2M4M_socratic = "GERMAN Excellent. What fraction have you made?";
		
		String gfF2M6M_socratic = "GERMAN Excellent. Now, how are you going to partition the fraction?";
		String gfF2M6M_guidance = "GERMAN Right click the fraction, select `find equivalent', and partition the fraction into two.";
		String gfF2M6M_didacticConceptual = "GERMAN Click the fraction with the right-hand mouse button, then select `find equivalent' and partition the fraction into two.";
		String gfF2M6M_didacticProcedural = "GERMAN Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into two.";
		
		String gfF2M7M_socratic = "GERMAN Excellent. Now, how are you going to partition the fraction into 3?";
		String gfF2M7M_guidance = "GERMAN Right click the fraction, select `find equivalent', and partition the fraction into 3.";
		String gfF2M7M_didacticConceptual = "GERMAN Click the fraction with the right-hand mouse button, then select `find equivalent', and partition the fraction into 3.";
		String gfF2M7M_didacticProcedural = "GERMAN Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into 3.";
		
		String gfF2M7bM_socratic = "GERMAN Excellent. Now, how are you going to partition the fraction into 4?";
		String gfF2M7bM_guidance = "GERMAN Right click the fraction, select `find equivalent', and partition the fraction into 4.";
		String gfF2M7bM_didacticConceptual = "GERMAN Click the fraction with the right-hand mouse button, then select `find equivalent', and partition the fraction into 4.";
		String gfF2M7bM_didacticProcedural = "GERMAN Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into 4.";
		
		String gfF2M7cM_socratic = "GERMAN Excellent. Now, how are you going to partition the fraction into 5?";
		String gfF2M7cM_guidance = "GERMAN Right click the fraction, select `find equivalent', and partition the fraction into 5.";
		String gfF2M7cM_didacticConceptual = "GERMAN Click the fraction with the right-hand mouse button, then select `find equivalent', and partition the fraction into 5.";
		String gfF2M7cM_didacticProcedural = "GERMAN Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into 5.";
		
		String gfF2M10M_socratic = "GERMAN Excellent. Is your new fraction equivalent to your original fraction? What has happened to the denominator and what has happened to the numerator?";
		
		String gfF2M11M_socratic = "GERMAN Excellent! Have you completed the task?";
		String gfF2M11M_guidance = "GERMAN Keep going. Now partition your fraction further.";
		
		String gfMF2E1M_didacticConceptual = "GERMAN Excellent, you have partitioned your fraction 2, 3, 4 and 5 times. Well done.";
		
		String gfMF2E2M_didacticConceptual = "GERMAN When you used find equivalent, what happened to the denominators and numerators?";
		
		
		String gfT24M1M_socratic = "GERMAN Is the denominator in your fraction correct?";
		String gfT24M1M_guidance = "GERMAN You can click the up arrow next to your fraction to change it.";
		String gfT24M1M_didacticConceptual = "GERMAN Check that the denominator in your fraction is correct.";
		String gfT24M1M_didacticProcedural = "GERMAN Check that the denominator (the bottom part of your fraction) is "+startDenominator+".";
		
		String gfT24M2M_socratic = "GERMAN Have you changed the numerator or denominator?";
		String gfT24M2M_guidance = "GERMAN Remember that the denominator is the bottom part of the fraction.";
		String gfT24M2M_didacticConceptual = "GERMAN Check that you have changed the denominator, not the numerator.";
		String gfT24M2M_didacticProcedural = "GERMAN Check that the denominator in your fraction, not the numerator, is "+startDenominator+".";
		
		String gfT24M3M_socratic = "GERMAN Is this the fraction you were planning to make?";
		String gfT24M3M_guidance = "GERMAN Please read the task again carefully.";
		String gfT24M3M_didacticConceptual = "GERMAN Re-read the task then check your fraction.";
		
		String gfT24M4M_didacticConceptual = "GERMAN Excellent. Please explain what the 'numerator' and `denominator' are";
		
		String gfT24M5M_socratic = "GERMAN Have you changed the denominator or the numerator?";
		String gfT24M5M_guidance = "TGERMAN he denominator is the bottom part of the fraction.";
		String gfT24M5M_didacticConceptual = "GERMAN You changed the numerator. You need to change the denominator.";
		String gfT24M5M_didacticProcedural = "GERMAN You changed the numerator. You need to change the denominator to "+startDenominator+".";
		
		String gfT24M6M_socratic = "GERMAN Excellent. Now, how are you going to change the numerator?";
		String gfT24M6M_guidance = "GERMAN If you click near the top of your fraction, and click the up arrow, you can change the numerator (the top part of the fraction).";
		String gfT24M6M_didacticConceptual = "GERMAN You changed the denominator. Now, change the numerator.";
		String gfT24M6M_didacticProcedural = "GERMAN Now, change the numerator. Remember, you need to make a fraction equivalent to "+startNumerator+"/"+startDenominator+".";
		
		String gfT24M7M_socratic = "GERMAN Excellent. How are you going to make an equivalent fraction?";
		String gfT24M7M_guidance = "GERMAN You could now copy the fraction and use `find equivalent' to make an equivalent fraction.";
		String gfT24M7M_didacticConceptual = "GERMAN Excellent. Now copy this fraction and use `find equivalent' to change it.";
		String gfT24M7M_didacticProcedural = "GERMAN Excellent. Now right click the fraction and copy it. Then right click the copy and select `find equivalent' to make an equivalent fraction.";
		
		String gfT24M8M_socratic = "GERMAN ow could you compare your fraction with "+startNumerator+"/"+startDenominator+".";
		String gfT24M8M_guidance = "GERMAN Think about the denominators in your fraction and in "+startNumerator+"/"+startDenominator+". What is the relationship between them? What do you need to do to "+startNumerator+" to work out the correct numerator for your fraction?";
		String gfT24M8M_didacticConceptual = "Compare your fraction with "+startNumerator+"/"+startDenominator+" by using the comparison box.";
		
		String gfT24M9M_socratic = "GERMAN What are you going to compare your fraction with?";
		String gfT24M9M_guidance = "GERMAN In equivalent fractions, the two numerators must be the same multiple of each other as the two denominators.";
		String gfT24M9M_didacticConceptual = "GERMAN First create another fraction, this time "+startNumerator+"/"+startDenominator+". Then compare your two fractions.";
		
		String gfT24M10M_didacticConceptual = "GERMAN Excellent. Please explain why you made the denominator "+startDenominator+" or a multiple of "+startDenominator+".";
		
		String gfT24M11M_socratic = "GERMAN How can you check, using a Fractions Lab tool,  that your solution is correct?";
		String gfT24M11M_guidance = "GERMAN You could use the comparison box to compare your fractions.";
		String gfT24M11M_didacticConceptual = "GERMAN Compare the two fractions using the comparison box.";
		
		String gfT24M12M_socratic = "GERMAN Now that you have made a fraction that is equivalent to "+startNumerator+"/"+startDenominator+", how are you going to compare it with "+startNumerator+"/"+startDenominator+"?";
		String gfT24M12M_guidance = "GERMAN Look at the task and think about what other fraction you need to make, to compare with your fraction.";
		String gfT24M12M_didacticConceptual = "GERMAN To compare your fraction to "+startNumerator+"/"+startDenominator+", you will need to make a second fraction, this time "+startNumerator+"/"+startDenominator+".";
		String gfT24M12M_didacticProcedural = "GERMAN Keep the fraction that you have made. Now create a second fraction. This time "+startNumerator+"/"+startDenominator+". Then compare the two fractions using the comparison box.";
		
		String gfT24M13M_socratic = "GERMAN Now that you have made a fraction that is equivalent to "+startNumerator+"/"+startDenominator+", how are you going to compare it with "+startNumerator+"/"+startDenominator+"?";
		String gfT24M13M_guidance = "GERMAN Look at the task and think about what other fraction you need to make, to compare with your fraction.";
		String gfT24M13M_didacticConceptual = "GERMAN To compare your fraction to "+startNumerator+"/"+startDenominator+", you will need to make a second fraction, this time "+startNumerator+"/"+startDenominator+".";
		String gfT24M13M_didacticProcedural = "GERMAN Keep the fraction that is equivalent to "+startNumerator+"/"+startDenominator+". Now change the other fraction to "+startNumerator+"/"+startDenominator+". Then compare the two fractions using the comparison box.";
		
		String gfT24E1M_didacticConceptual = "GERMAN The way that you worked that out was excellent. Well done.";
		
		String gfT24E2M_didacticConceptual = "GERMAN Please explain what you did to the numerator and denominator of "+startNumerator+"/"+startDenominator+" to make an equivalent fraction.";
		
		
		
		String gfT26M1M_guidance = "GERMAN You can click the up arrow next to your fraction to change it.";
		String gfT26M1M_socratic = "GERMAN Is the denominator in your fraction correct?";
		String gfT26M1M_didacticConceptual = "GERMAN Check that the denominator in your fraction is correct.";
		String gfT26M1M_didacticProcedural = "GERMAN Check that the denominator (the bottom part of your fraction) is "+startDenominator+" or "+endDenominator+".";
		
		String gfT26M2M_guidance = "GERMAN Remember that the denominator is the bottom part of the fraction.";
		String gfT26M2M_socratic = "GERMAN Have you changed the numerator or denominator?";
		String gfT26M2M_didacticConceptual = "GERMAN Check that you have changed the denominator, not the numerator.";
		String gfT26M2M_didacticProcedural = "GERMAN Check that the denominator in your fraction, not the numerator, is "+startDenominator+" or "+endDenominator+".";
		
		String gfT26M3M_guidance = "GERMAN Please read the task again carefully.";
		String gfT26M3M_socratic = "GERMAN Is this the fraction you were planning to make?";
		String gfT26M3M_didacticConceptual = "GERMAN Re-read the task then check your fraction.";
		
		String gfT26M4M_didacticConceptual = "GERMAN Excellent. Please explain what the 'numerator' and `denominator' are.";
		
		String gfT26M5M_guidance = "GERMAN The denominator is the bottom part of the fraction.";
		String gfT26M5M_socratic = "GERMAN Have you changed the denominator or the numerator?";
		String gfT26M5M_didacticConceptual = "GERMAN You changed the numerator. You need to change the denominator.";
		String gfT26M5M_didacticProcedural = "GERMAN You changed the numerator. You need to change the denominator to "+startDenominator+" or "+endDenominator+".";
		
		String gfT26M6M_guidance = "GERMAN If you click near the top of your fraction, and click the up arrow, you can change the numerator (the top part of the fraction).";
		String gfT26M6M_socratic = "GERMAN Excellent. Now, how are you going to change the numerator?";
		String gfT26M6M_didacticConceptual = "GERMAN You changed the denominator.  Now, change the numerator.";
		String gfT26M6M_didacticProcedural = "GERMAN Now, change the numerator. Remember, you need to make the fraction "+startNumerator+"/"+startDenominator+" or "+endNumerator+"/"+endDenominator+".";
		
		String gfT26M7M_guidance = "GERMAN There are two fractions in this task.  You can make another fraction by using the representation tool.";
		String gfT26M7M_socratic = "GERMAN Excellent. How are you going to make the second fraction?";
		String gfT26M7M_didacticConceptual = "GERMAN Please make the other fraction.";
		String gfT26M7M_didacticProcedural = "GERMAN You have made "+startNumerator+"/"+startDenominator+" or "+endNumerator+"/"+endDenominator+".  Please make "+startNumerator+"/"+startDenominator+" or "+endNumerator+"/"+endDenominator+".";
		
		String gfT26M8M_guidance = "GERMAN It is easier to compare fractions when they are represented the same way.";
		String gfT26M8M_socratic = "GERMAN Can you think of a clearer way to represent the fractions?";
		String gfT26M8M_didacticConceptual = "GERMAN Please change one of your fractions so they use the same representation.";
		
		String gfT26M10M_didacticConceptual = "GERMAN Great. Please explain why you made these fractions.";
		
		String gfT26M11M_guidance = "GERMAN You could use the comparison box to compare your fractions.";
		String gfT26M11M_socratic = "GERMAN How can you check, using a Fractions Lab tool,  that your solution is correct?";
		String gfT26M11M_didacticConceptual = "GERMAN Compare the two fractions using the comparison box.";
		
		String gfT26E1M_didacticConceptual = "GERMAN The way that you worked that out was excellent. Well done.";
		
		String gfT26E2M_didacticConceptual = "GERMAN Please explain why you agree or disagree.";
		
		
		
		String gfT3aP1M1M_socratic = "GERMAN Is the denominator in your fraction correct?";
		String gfT3aP1M1M_guidance = "GERMAN You can click the up arrow next to your fraction to change it.";
		String gfT3aP1M1M_didacticConceptual = "GERMAN Check that the denominator in your fraction is correct.";
		String gfT3aP1M1M_didacticProcedural = "GERMAN Check that the denominator (the bottom part of your fraction) is "+startDenominator+".";
		
		String gfT3aP1M2M_socratic = "GERMAN Have you changed the numerator or denominator?";
		String gfT3aP1M2M_guidance = "GERMAN Remember that the denominator is the bottom part of the fraction.";
		String gfT3aP1M2M_didacticConceptual = "GERMAN Check that you have changed the denominator, not the numerator.";
		String gfT3aP1M2M_didacticProcedural = "GERMAN Check that the denominator in your fraction, not the numerator, is "+startDenominator+".";
		
		String gfT3aP1M3M_socratic = "GERMAN Is this the fraction you were planning to make?";
		String gfT3aP1M3M_guidance = "GERMAN Please read the task again carefully.";
		String gfT3aP1M3M_didacticConceptual = "GERMAN Re-read the task then check your fraction.";
		
		String gfT3aP1M4M_didacticConceptual = "GERMAN Excellent. Please explain what the 'numerator' and `denominator' are.";
		
		String gfT3aP1M5M_socratic = "GERMAN Have you changed the denominator or the numerator?";
		String gfT3aP1M5M_guidance = "GERMAN The denominator is the bottom part of the fraction.";
		String gfT3aP1M5M_didacticConceptual = "GERMAN You changed the numerator. You need to change the denominator.";
		String gfT3aP1M5M_didacticProcedural = "GERMAN You changed the numerator. You need to change the denominator to "+startDenominator+".";
		
		String gfT3aP1M6M_socratic = "GERMAN Excellent. Now, how are you going to change the numerator?";
		String gfT3aP1M6M_guidance = "GERMAN If you click near the top of your fraction, and click the up arrow, you can change the numerator (the top part of the fraction).";
		String gfT3aP1M6M_didacticConceptual = "GERMAN You changed the denominator.  Now, change the numerator.";
		String gfT3aP1M6M_didacticProcedural = "GERMAN Now, change the numerator. Remember, you need to make two fractions that can be added together to make "+startNumerator+"/"+startDenominator+".";
		
		String gfT3aP1M7M_socratic = "GERMAN Excellent. You've made one fraction. What do you need to do now, to complete the task?";
		String gfT3aP1M7M_guidance = "GERMAN You now need to make a second fraction that, when added together with your first fraction, makes the fraction shown in the task.";
		
		String gfT3aP1M8M_socratic = "GERMAN Think about how you add two fractions together. What needs to be the same, and what do you need to add together?";
		String gfT3aP1M8M_guidance = "GERMAN To add two fractions together, the denominators need to be the same. Then you add together the numerators.";
		
		String gfT3aP1M10M_didacticConceptual = "GERMAN Excellent. Please explain why you made the denominator "+startDenominator+".";
		
		String gfT3aP1M11M_socratic = "GERMAN How can you check, using a Fractions Lab tool,  that your solution is correct?";
		String gfT3aP1M11M_guidance = "GERMAN You could use the addition box to add your fractions.";
		String gfT3aP1M11M_didacticConceptual = "GERMAN Add your two fractions using the addition box.";
		
		String gfT3aP1E1M_didacticConceptual = "GERMAN The way that you worked that out was excellent. Well done.";
		
		String gfT3aP1E2M_didacticConceptual = "GERMAN Please explain how you answered the task. Why did you make the fractions that you made?.";

		String sfS1M_socratic = "SPANISH How are you going to tackle this task?";
		String sfS1M_didacticConceptual = "SPANISH Read the task again, and explain how you are going to tackle it.";
		
		String sfS2M_socratic = "SPANISH What do you need to do in this task?";
		String sfS2M_guidance = "SPANISH You can click one of the buttons on the representations toolbox to create a fraction.";
		String sfS2M_didacticConceptual ="SPANISH Read the task again, and explain how you are going to tackle it.";
		
		String sfS3M_socratic = "SPANISH Good. What do you need to do now, to change the fraction?";
		String sfS3M_guidance = "SPANISH You can use the arrow buttons to change the fraction.";
		String sfS3M_didacticConceptual = "SPANISH Now click the up arrow next to the empty fraction, to make the denominator.";
		String sfS3M_didacticProcedural = "SPANISH Click the up arrow next to the empty fraction, to make the denominator (the bottom part of the fraction) "+endDenominator+".";
		
		String sfM1M_socratic = "SPANISH Is the denominator in your fraction correct?";
		String sfM1M_guidance = "SPANISH You can click the up arrow next to your fraction to change the denominator.";
		String sfM1M_didacticConceptual = "SPANISH Check that the denominator in your fraction is correct.";
		String sfM1M_didacticProcedural = "SPANISH Check that the denominator (the bottom part of your fraction) is "+endDenominator+".";
		
		String sfM2M_socratic = "SPANISH Have you changed the numerator or the denominator?";
		String sfM2M_guidance = "SPANISH Remember that the denominator is the bottom part of the fraction.";
		String sfM2M_didacticConceptual = "SPANISH Check that you have changed the denominator, not the numerator.";
		String sfM2M_didacticProcedural = "SPANISH Check that the denominator in your fraction, not the numerator, is "+endDenominator+".";
		
		String sfCM2M_socratic  = "SPANISH Have you changed the numerator or the denominator?";
		String sfCM2M_guidance = "SPANISH Remember that the denominator is the bottom part of the fraction.";
		String sfCM2M_didacticConceptual = "SPANISH Check that you have changed the denominator, not the numerator.";
		String sfCM2M_didacticProcedural = "SPANISH Check that the denominator in your fraction, not the numerator, is "+endDenominator+".";
		
		String sfM3M_socratic = "SPANISH Is this the fraction you were planning to make?";
		String sfM3M_guidance = "SPANISH Please read the task again carefully.";
		String sfM3M_didacticConceptual = "SPANISH Re-read the task then echeck your fraction.";
		
		String sfM4M_didacticConceptual = "SPANISH Excellent. Please explain what the numerator and denominator are.";
		
		String sfM5M_socratic = "SPANISH Have you changed the denominator or the numerator?";
		String sfM5M_guidance = "SPANISH The denominator is the bottom part of the fraction.";
		String sfM5M_didacticConceptual = "SPANISH You changed the numerator. You need to change the denominator.";
		String sfM5M_didacticProcedural = "SPANISH You changed the numerator. You need to change the denominator to "+endDenominator+".";
		
		String sfCM5M_socratic = "SPANISH Have you changed the denominator or the numerator?";
		String sfCM5M_guidance = "SPANISH The denominator is the bottom part of the fraction.";
		String sfCM5M_didacticConceptual = "SPANISH You changed the numerator. You need to change the denominator.";
		String sfCM5M_didacticProcedural = "SPANISH You changed the numerator. You need to change the denominator to "+endDenominator+".";
		
		String sfM6M_socratic = "SPANISH Excellent. Now, how are you going to change the numerator?";
		String sfM6M_guidance = "SPANISH If you click near the top of your fraction, and click the arrow, you can change the numerator (the top part of the fraction).";
		String sfM6M_didacticConceptual = "SPANISH You changed the denominator. Now, change the numerator.";
		String sfM6M_didacticProcedural = "SPANISH Now, change the numerator. Remember, you need to make the fraction equivalent to "+startNumerator+"/"+startDenominator+".";
		
		String sfCM6M_socratic = "SPANISH Excellent. Now, how are you going to compare the fraction?";
		String sfCM6M_guidance = "SPANISH Now that you have made the first fraction, you need to compare it with the second fraction.";
		String sfCM6M_didacticConceptual = "SPANISH You now need to compare the fraction with a second fraction.";
		String sfCM6M_didacticProcedural = "SPANISH Now, create a second fraction using the same representation.";
		
		String sfCM6MSecond_socratic = "SPANISH Excellent. Now, how are you going to compare the fraction?";
		String sfCM6MSecond_guidance = "SPANISH Now that you have made the first fraction, you need to compare it with the second fraction.";
		String sfCM6MSecond_didacticConceptual = "SPANISH You now need to compare the fraction with a second fraction.";
		String sfCM6MSecond_didacticProcedural = "SPANISH Now, create a second fraction using the same representation.";
		
		String sfM7M_socratic = "SPANISH Excellent. How are you going to make the equivalent fraction?";
		String sfM7M_guidance = "SPANISH You could now copy the fraction and use `find equivalent' to make an equivalent fraction. Right-click the fraction.";
		String sfM7M_didacticConceptual = "SPANISH Excellent. Now copy this fraction, right click the copy, and select `find equivalent'.";
		String sfM7M_didacticProcedural = "SPANISH Excellent. Now copy this fraction, right click the copy, and select `find equivalent' to make a fraction with a denominator of "+endDenominator+".";
		
		String sfCM7M_socratic = "SPANISH Why have you decided to use a different representation? What does the task ask you to do?";
		String sfCM7M_guidance = "SPANISH Please use the same representation for the second fraction.";
		String sfCM7M_didacticProcedural = "SPANISH Please create the second fraction using the same representation that you used for the first fraction.";
		
		String sfM8M_socratic = "SPANISH Now that you have made "+endNumerator+"/"+endDenominator+" how are you going to compare it with "+startNumerator+"/"+startDenominator+"?";
		String sfM8M_guidance = "SPANISH Look at the task and think about what other fraction you need to make to compare it with "+endNumerator+"/"+endDenominator+".";
		String sfM8M_didacticConceptual = "SPANISH You need one of your fractions to be "+startNumerator+"/"+startDenominator+", to compare it with "+endNumerator+"/"+endDenominator+".";
		String sfM8M_didacticProcedural = "SPANISH Keep the fraction "+endNumerator+"/"+endDenominator+". Now change the other fraction to "+startNumerator+"/"+startDenominator+". Then compare the two fractions using the comparison box.";
		
		String sfM9M_socratic = "SPANISH How are you going to make a fraction with the denominator "+endDenominator+", that is equivalent to "+startNumerator+"/"+startDenominator+".";
		String sfM9M_guidance = "SPANISH Look at the task and think about what other fraction you need to make to compare it with "+startNumerator+"/"+startDenominator+".";
		String sfM9M_didacticConceptual = "SPANISH As well as "+startNumerator+"/"+startDenominator+", you need a second fraction that is equivalent to "+startNumerator+"/"+startDenominator+" and that has "+endDenominator+" as its denominator.";
		String sfM9M_didacticProcedural = "SPANISH Keep the fraction "+startNumerator+"/"+startDenominator+". Now change the other fraction to "+endNumerator+"/"+endDenominator+". Then compare the two fractions using the comparison box.";
		
		String sfM10M_socratic = "SPANISH How could you compare your fraction with "+startNumerator+"/"+startDenominator+"?";
		String sfM10M_guidance = "SPANISH Think about the denominators in the two fractions. What is the relationship between them?";
		String sfM10M_didacticConceptual = "SPANISH Compare your fraction with "+startNumerator+"/"+startDenominator+"  by creating another fraction, this time "+startNumerator+"/"+startDenominator+", and using the comparison box.";
		
		String sfCM8M_socratic = "SPANISH Excellent. How using the comparison tool to compare the two fractions?";
		String sfCM8M_guidance = "SPANISH You could now compare the fractions. Open the comparison tool at the top of the screen.";
		String sfCM8M_didacticConceptual = "SPANISH Excellent. Now use the comparison tool.";
		String sfCM8M_didacticProcedural = "SPANISH Excellent. Not open the comparison tool, at the top of the screen, and drag in the two fractions.";
		
		String sfM11M_socratic = "SPANISH What are you going to compare your fraction with?";
		String sfM11M_guidance = "SPANISH In equivalent fractions, the two numerators must be the same multiple of each other as the two denominators.";
		String sfM11M_didacticConceptual = "SPANISH First create another fraction, this time "+startNumerator+"/"+startDenominator+". Then compare your two fractions.";
		
		String sfM12M_didacticConceptual = "SPANISH Excellent. Please explain why you made the denominator "+endDenominator+".";
		
		String sfM13M_socratic = "SPANISH How can you check, using a Fractions Lab tool, that your solution is correct?";
		String sfM13M_guidance = "SPANISH You could use the comparison box to compare your fractions.";
		String sfM13M_didacticConceptual = "SPANISH Compare the two fractions using the comparison box.";
		
		String sfCM11M_didacticConceptual = "SPANISH Excellent. Please explain why you made the denominator 3.";
		
		String sfCM12M_socratic = "SPANISH Excellent, what are you going to do now?";
		
		String sfE1M_didacticConceptual = "SPANISH The way that you worked that out was excellent. Well done.";
		
		String sfE2M_didacticConceptual = "SPANISH Please explain what you did to the numerator and the denominator of "+startNumerator+"/"+startDenominator+" to make an equivalent fraction with "+endDenominator+" as the denominator.";
		
		String sfCE2M_didacticConceptual = "SPANISH Please explain what you found by comparing 1/3 and 1/5.";
		
		String sfR1M_didacticConceptual = "SPANISH What has happened to the numerator and denominator? Have they been affected the same or differently?";
		
		String sfR2M_didacticConceptual = "SPANISH Why did you make the fraction "+endNumerator+"/"+endDenominator+"? What did you do to the numerator and denominator of "+startNumerator+"/"+startDenominator+"?";
		
		String sfO1M_didacticConceptual = "SPANISH You don't appear to have completed the task.";
		
		String sfO2M_didacticConceptual = "SPANISH If you need more help to finish the task, you could ask your teacher.";
		
		String sfMF6M_socratic = "SPANISH Excellent. Now, how are you going to use a different representation?";
		String sfMF6M_guidance = "SPANISH Excellent, Now, click the representation toolbar and create another representation of exactly the same fraction.";
		
		String sfMF10M_socratic = "SPANISH Excellent. How are your representations similar, and how are they different?";
		
		String sfMF11M_socratic = "SPANISH Excellent! Have you completed the task?";
		String sfMF11M_guidance = "SPANISH Excellent! Keep going. Now make your fraction using a different representation.";
		
		String sfMF12M_socratic = "SPANISH Excellent! Do your fractions have the same values?";
		String sfMF12M_guidance = "SPANISH Excellent! Now change your fractions to the same values.";
		
		String sfMFE1M_didacticConceptual = "SPANISH Excellent, you have made your fraction using all the representations. Well done.";
		
		String sfMFE2M_didacticConceptual ="SPANISH How are all your representations similar, and how are they different?";
		
		String sfF2M1M_socratic = "SPANISH Good. What do you need to do now, to complete the fraction?";
		String sfF2M1M_guidance = "SPANISH You can use the arrow buttons at the top of the fraction to complete your fraction.";
		String sfF2M1M_didacticConceptual = "SPANISH Now click the up arrow next to the top of the fraction, to make the numerator.";
		String sfF2M1M_didacticProcedural = "SPANISH Click the up arrow next to the top of the fraction, to make the numerator (the top part of the fraction).";
		
		String sfF2M4M_socratic = "SPANISH Excellent. What fraction have you made?";
		
		String sfF2M6M_socratic = "SPANISH Excellent. Now, how are you going to partition the fraction?";
		String sfF2M6M_guidance = "SPANISH Right click the fraction, select `find equivalent', and partition the fraction into two.";
		String sfF2M6M_didacticConceptual = "SPANISH Click the fraction with the right-hand mouse button, then select `find equivalent' and partition the fraction into two.";
		String sfF2M6M_didacticProcedural = "SPANISH Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into two.";
		
		String sfF2M7M_socratic = "SPANISH Excellent. Now, how are you going to partition the fraction into 3?";
		String sfF2M7M_guidance = "SPANISH Right click the fraction, select `find equivalent', and partition the fraction into 3.";
		String sfF2M7M_didacticConceptual = "SPANISH Click the fraction with the right-hand mouse button, then select `find equivalent', and partition the fraction into 3.";
		String sfF2M7M_didacticProcedural = "SPANISH Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into 3.";
		
		String sfF2M7bM_socratic = "SPANISH Excellent. Now, how are you going to partition the fraction into 4?";
		String sfF2M7bM_guidance = "SPANISH Right click the fraction, select `find equivalent', and partition the fraction into 4.";
		String sfF2M7bM_didacticConceptual = "SPANISH Click the fraction with the right-hand mouse button, then select `find equivalent', and partition the fraction into 4.";
		String sfF2M7bM_didacticProcedural = "SPANISH Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into 4.";
		
		String sfF2M7cM_socratic = "SPANISH Excellent. Now, how are you going to partition the fraction into 5?";
		String sfF2M7cM_guidance = "SPANISH Right click the fraction, select `find equivalent', and partition the fraction into 5.";
		String sfF2M7cM_didacticConceptual = "SPANISH Click the fraction with the right-hand mouse button, then select `find equivalent', and partition the fraction into 5.";
		String sfF2M7cM_didacticProcedural = "SPANISH Click the fraction with the right-hand mouse button. Then click `find equivalent'. Then click to partition the fraction into 5.";
		
		String sfF2M10M_socratic = "SPANISH Excellent. Is your new fraction equivalent to your original fraction? What has happened to the denominator and what has happened to the numerator?";
		
		String sfF2M11M_socratic = "SPANISH Excellent! Have you completed the task?";
		String sfF2M11M_guidance = "SPANISH Keep going. Now partition your fraction further.";
		
		String sfMF2E1M_didacticConceptual = "SPANISH Excellent, you have partitioned your fraction 2, 3, 4 and 5 times. Well done.";
		
		String sfMF2E2M_didacticConceptual = "SPANISH When you used find equivalent, what happened to the denominators and numerators?";
		
		
		String sfT24M1M_socratic = "SPANISH Is the denominator in your fraction correct?";
		String sfT24M1M_guidance = "SPANISH You can click the up arrow next to your fraction to change it.";
		String sfT24M1M_didacticConceptual = "SPANISH Check that the denominator in your fraction is correct.";
		String sfT24M1M_didacticProcedural = "SPANISH Check that the denominator (the bottom part of your fraction) is "+startDenominator+".";
		
		String sfT24M2M_socratic = "SPANISH Have you changed the numerator or denominator?";
		String sfT24M2M_guidance = "SPANISH Remember that the denominator is the bottom part of the fraction.";
		String sfT24M2M_didacticConceptual = "SPANISH Check that you have changed the denominator, not the numerator.";
		String sfT24M2M_didacticProcedural = "SPANISH Check that the denominator in your fraction, not the numerator, is "+startDenominator+".";
		
		String sfT24M3M_socratic = "SPANISH Is this the fraction you were planning to make?";
		String sfT24M3M_guidance = "SPANISH Please read the task again carefully.";
		String sfT24M3M_didacticConceptual = "SPANISH Re-read the task then check your fraction.";
		
		String sfT24M4M_didacticConceptual = "SPANISH Excellent. Please explain what the 'numerator' and `denominator' are";
		
		String sfT24M5M_socratic = "SPANISH Have you changed the denominator or the numerator?";
		String sfT24M5M_guidance = "SPANISH The denominator is the bottom part of the fraction.";
		String sfT24M5M_didacticConceptual = "SPANISH You changed the numerator. You need to change the denominator.";
		String sfT24M5M_didacticProcedural = "SPANISH You changed the numerator. You need to change the denominator to "+startDenominator+".";
		
		String sfT24M6M_socratic = "SPANISH Excellent. Now, how are you going to change the numerator?";
		String sfT24M6M_guidance = "SPANISH If you click near the top of your fraction, and click the up arrow, you can change the numerator (the top part of the fraction).";
		String sfT24M6M_didacticConceptual = "SPANISH You changed the denominator. Now, change the numerator.";
		String sfT24M6M_didacticProcedural = "SPANISH Now, change the numerator. Remember, you need to make a fraction equivalent to "+startNumerator+"/"+startDenominator+".";
		
		String sfT24M7M_socratic = "SPANISH Excellent. How are you going to make an equivalent fraction?";
		String sfT24M7M_guidance = "SPANISH You could now copy the fraction and use `find equivalent' to make an equivalent fraction.";
		String sfT24M7M_didacticConceptual = "SPANISH Excellent. Now copy this fraction and use `find equivalent' to change it.";
		String sfT24M7M_didacticProcedural = "SPANISH Excellent. Now right click the fraction and copy it. Then right click the copy and select `find equivalent' to make an equivalent fraction.";
		
		String sfT24M8M_socratic = "SPANISH How could you compare your fraction with "+startNumerator+"/"+startDenominator+".";
		String sfT24M8M_guidance = "SPANISH Think about the denominators in your fraction and in "+startNumerator+"/"+startDenominator+". What is the relationship between them? What do you need to do to "+startNumerator+" to work out the correct numerator for your fraction?";
		String sfT24M8M_didacticConceptual = "SPANISH Compare your fraction with "+startNumerator+"/"+startDenominator+" by using the comparison box.";
		
		String sfT24M9M_socratic = "SPANISH What are you going to compare your fraction with?";
		String sfT24M9M_guidance = "SPANISH In equivalent fractions, the two numerators must be the same multiple of each other as the two denominators.";
		String sfT24M9M_didacticConceptual = "SPANISH First create another fraction, this time "+startNumerator+"/"+startDenominator+". Then compare your two fractions.";
		
		String sfT24M10M_didacticConceptual = "SPANISH Excellent. Please explain why you made the denominator "+startDenominator+" or a multiple of "+startDenominator+".";
		
		String sfT24M11M_socratic = "SPANISH How can you check, using a Fractions Lab tool,  that your solution is correct?";
		String sfT24M11M_guidance = "SPANISH You could use the comparison box to compare your fractions.";
		String sfT24M11M_didacticConceptual = "SPANISH Compare the two fractions using the comparison box.";
		
		String sfT24M12M_socratic = "SPANISH Now that you have made a fraction that is equivalent to "+startNumerator+"/"+startDenominator+", how are you going to compare it with "+startNumerator+"/"+startDenominator+"?";
		String sfT24M12M_guidance = "SPANISH Look at the task and think about what other fraction you need to make, to compare with your fraction.";
		String sfT24M12M_didacticConceptual = "SPANISH To compare your fraction to "+startNumerator+"/"+startDenominator+", you will need to make a second fraction, this time "+startNumerator+"/"+startDenominator+".";
		String sfT24M12M_didacticProcedural = "SPANISH Keep the fraction that you have made. Now create a second fraction. This time "+startNumerator+"/"+startDenominator+". Then compare the two fractions using the comparison box.";
		
		String sfT24M13M_socratic = "SPANISH Now that you have made a fraction that is equivalent to "+startNumerator+"/"+startDenominator+", how are you going to compare it with "+startNumerator+"/"+startDenominator+"?";
		String sfT24M13M_guidance = "SPANISH Look at the task and think about what other fraction you need to make, to compare with your fraction.";
		String sfT24M13M_didacticConceptual = "SPANISH To compare your fraction to "+startNumerator+"/"+startDenominator+", you will need to make a second fraction, this time "+startNumerator+"/"+startDenominator+".";
		String sfT24M13M_didacticProcedural = "SPANISH Keep the fraction that is equivalent to "+startNumerator+"/"+startDenominator+". Now change the other fraction to "+startNumerator+"/"+startDenominator+". Then compare the two fractions using the comparison box.";
		
		String sfT24E1M_didacticConceptual = "SPANISH The way that you worked that out was excellent. Well done.";
		
		String sfT24E2M_didacticConceptual = "SPANISH Please explain what you did to the numerator and denominator of "+startNumerator+"/"+startDenominator+" to make an equivalent fraction.";
		
		
		
		String sfT26M1M_guidance = "SPANISH You can click the up arrow next to your fraction to change it.";
		String sfT26M1M_socratic = "SPANISH Is the denominator in your fraction correct?";
		String sfT26M1M_didacticConceptual = "SPANISH Check that the denominator in your fraction is correct.";
		String sfT26M1M_didacticProcedural = "SPANISH Check that the denominator (the bottom part of your fraction) is "+startDenominator+" or "+endDenominator+".";
		
		String sfT26M2M_guidance = "SPANISH Remember that the denominator is the bottom part of the fraction.";
		String sfT26M2M_socratic = "SPANISH Have you changed the numerator or denominator?";
		String sfT26M2M_didacticConceptual = "SPANISH Check that you have changed the denominator, not the numerator.";
		String sfT26M2M_didacticProcedural = "SPANISH Check that the denominator in your fraction, not the numerator, is "+startDenominator+" or "+endDenominator+".";
		
		String sfT26M3M_guidance = "SPANISH Please read the task again carefully.";
		String sfT26M3M_socratic = "SPANISH Is this the fraction you were planning to make?";
		String sfT26M3M_didacticConceptual = "SPANISH Re-read the task then check your fraction.";
		
		String sfT26M4M_didacticConceptual = "SPANISH Excellent. Please explain what the 'numerator' and `denominator' are.";
		
		String sfT26M5M_guidance = "SPANISH The denominator is the bottom part of the fraction.";
		String sfT26M5M_socratic = "SPANISH Have you changed the denominator or the numerator?";
		String sfT26M5M_didacticConceptual = "SPANISH You changed the numerator. You need to change the denominator.";
		String sfT26M5M_didacticProcedural = "SPANISH You changed the numerator. You need to change the denominator to "+startDenominator+" or "+endDenominator+".";
		
		String sfT26M6M_guidance = "SPANISH If you click near the top of your fraction, and click the up arrow, you can change the numerator (the top part of the fraction).";
		String sfT26M6M_socratic = "SPANISH Excellent. Now, how are you going to change the numerator?";
		String sfT26M6M_didacticConceptual = "SPANISH You changed the denominator.  Now, change the numerator.";
		String sfT26M6M_didacticProcedural = "SPANISH Now, change the numerator. Remember, you need to make the fraction "+startNumerator+"/"+startDenominator+" or "+endNumerator+"/"+endDenominator+".";
		
		String sfT26M7M_guidance = "SPANISH There are two fractions in this task.  You can make another fraction by using the representation tool.";
		String sfT26M7M_socratic = "SPANISH Excellent. How are you going to make the second fraction?";
		String sfT26M7M_didacticConceptual = "SPANISH Please make the other fraction.";
		String sfT26M7M_didacticProcedural = "SPANISH You have made "+startNumerator+"/"+startDenominator+" or "+endNumerator+"/"+endDenominator+".  Please make "+startNumerator+"/"+startDenominator+" or "+endNumerator+"/"+endDenominator+".";
		
		String sfT26M8M_guidance = "SPANISH It is easier to compare fractions when they are represented the same way.";
		String sfT26M8M_socratic = "SPANISH Can you think of a clearer way to represent the fractions?";
		String sfT26M8M_didacticConceptual = "SPANISH Please change one of your fractions so they use the same representation.";
		
		String sfT26M10M_didacticConceptual = "SPANISH Great. Please explain why you made these fractions.";
		
		String sfT26M11M_guidance = "SPANISH You could use the comparison box to compare your fractions.";
		String sfT26M11M_socratic = "SPANISH How can you check, using a Fractions Lab tool,  that your solution is correct?";
		String sfT26M11M_didacticConceptual = "SPANISH Compare the two fractions using the comparison box.";
		
		String sfT26E1M_didacticConceptual = "SPANISH The way that you worked that out was excellent. Well done.";
		
		String sfT26E2M_didacticConceptual = "SPANISH Please explain why you agree or disagree.";
		
		
		
		String sfT3aP1M1M_socratic = "SPANISH Is the denominator in your fraction correct?";
		String sfT3aP1M1M_guidance = "SPANISH You can click the up arrow next to your fraction to change it.";
		String sfT3aP1M1M_didacticConceptual = "SPANISH Check that the denominator in your fraction is correct.";
		String sfT3aP1M1M_didacticProcedural = "SPANISH Check that the denominator (the bottom part of your fraction) is "+startDenominator+".";
		
		String sfT3aP1M2M_socratic = "SPANISH Have you changed the numerator or denominator?";
		String sfT3aP1M2M_guidance = "SPANISH Remember that the denominator is the bottom part of the fraction.";
		String sfT3aP1M2M_didacticConceptual = "SPANISH Check that you have changed the denominator, not the numerator.";
		String sfT3aP1M2M_didacticProcedural = "SPANISH Check that the denominator in your fraction, not the numerator, is "+startDenominator+".";
		
		String sfT3aP1M3M_socratic = "SPANISH Is this the fraction you were planning to make?";
		String sfT3aP1M3M_guidance = "SPANISH Please read the task again carefully.";
		String sfT3aP1M3M_didacticConceptual = "SPANISH Re-read the task then check your fraction.";
		
		String sfT3aP1M4M_didacticConceptual = "SPANISH Excellent. Please explain what the 'numerator' and `denominator' are.";
		
		String sfT3aP1M5M_socratic = "SPANISH Have you changed the denominator or the numerator?";
		String sfT3aP1M5M_guidance = "SPANISH The denominator is the bottom part of the fraction.";
		String sfT3aP1M5M_didacticConceptual = "SPANISH You changed the numerator. You need to change the denominator.";
		String sfT3aP1M5M_didacticProcedural = "SPANISH You changed the numerator. You need to change the denominator to "+startDenominator+".";
		
		String sfT3aP1M6M_socratic = "SPANISH Excellent. Now, how are you going to change the numerator?";
		String sfT3aP1M6M_guidance = "SPANISH If you click near the top of your fraction, and click the up arrow, you can change the numerator (the top part of the fraction).";
		String sfT3aP1M6M_didacticConceptual = "SPANISH You changed the denominator.  Now, change the numerator.";
		String sfT3aP1M6M_didacticProcedural = "SPANISH Now, change the numerator. Remember, you need to make two fractions that can be added together to make "+startNumerator+"/"+startDenominator+".";
		
		String sfT3aP1M7M_socratic = "SPANISH Excellent. You've made one fraction. What do you need to do now, to complete the task?";
		String sfT3aP1M7M_guidance = "SPANISH You now need to make a second fraction that, when added together with your first fraction, makes the fraction shown in the task.";
		
		String sfT3aP1M8M_socratic = "SPANISH Think about how you add two fractions together. What needs to be the same, and what do you need to add together?";
		String sfT3aP1M8M_guidance = "SPANISH To add two fractions together, the denominators need to be the same. Then you add together the numerators.";
		
		String sfT3aP1M10M_didacticConceptual = "SPANISH Excellent. Please explain why you made the denominator "+startDenominator+".";
		
		String sfT3aP1M11M_socratic = "SPANISH How can you check, using a Fractions Lab tool,  that your solution is correct?";
		String sfT3aP1M11M_guidance = "SPANISH You could use the addition box to add your fractions.";
		String sfT3aP1M11M_didacticConceptual = "SPANISH Add your two fractions using the addition box.";
		
		String sfT3aP1E1M_didacticConceptual = "SPANISH The way that you worked that out was excellent. Well done.";
		
		String sfT3aP1E2M_didacticConceptual = "SPANISH Please explain how you answered the task. Why did you make the fractions that you made?.";


		public FeedbackMessageString (bool englishValue, bool germanValue, bool spanishValue){
			english = englishValue;
			german  = germanValue;
			spanish = spanishValue;
		}


			
		public void setStartNumerator(int value){
			startNumerator = value;
		}

		public void setEndNumerator(int value){
			endNumerator = value;
		}
	
		public void setStartDenominator(int value){
			startDenominator = value;
		}

		public void setEndDenominator(int value){
			endDenominator = value;
		}


		public String S1M_socratic(){
			if (spanish) {
				return sfS1M_socratic;
			} else if (german) {
				return gfS1M_socratic;
			} else {
				return fS1M_socratic;		
			}
		}

		public String S1M_didacticConceptual(){
			if (spanish) {
				return sfS1M_didacticConceptual;
			} 
			else if (german){
				return gfS1M_didacticConceptual;
			}
			else {
				return fS1M_didacticConceptual;	
			}
		}
		
		public String S2M_socratic(){
			if (spanish) {
				return sfS2M_socratic;
			} else if (german){
				return gfS2M_socratic;
			}
			else {
				return fS2M_socratic;
			}
		}

		public String S2M_guidance(){
			if (spanish) {
				return sfS2M_guidance;
			} 
			else if (german){
				return gfS2M_guidance;
			}
			else {
				return fS2M_guidance;
			}
		}
		public String S2M_didacticConceptual(){
			if (spanish) {
				return sfS2M_didacticConceptual;
			} 
			else if (german){
				return gfS2M_didacticConceptual;
			}
			else {
				return fS2M_didacticConceptual;
			}
		}
		
		public String S3M_socratic(){
			if (spanish) {
				return sfS3M_socratic;
			} 
			else if (german){
				return gfS3M_socratic;
			}
			else {
				return fS3M_socratic;
			}
		}

		public String S3M_guidance(){
			if (spanish) {
				return sfS3M_guidance;
			} 
			else if (german){
				return gfS3M_guidance;
			}
			else {
				return fS3M_guidance;
			}
		}

		public String S3M_didacticConceptual(){
			if (spanish) {
				return sfS3M_didacticConceptual;
			} 
			else if (german){
				return gfS3M_didacticConceptual;
			}
			else {
				return fS3M_didacticConceptual;
			}
		}

		public String S3M_didacticProcedural(){
			if (spanish) {
				return sfS3M_didacticProcedural;	
			} 
			else if (german){
				return gfS3M_didacticProcedural;	
			}
			else {
				return fS3M_didacticProcedural;	
			}
		}

		public String M1M_socratic(){
			if (spanish) {
				return sfM1M_socratic;
			} 
			else if (german){
				return gfM1M_socratic;
			}
			else {
				return fM1M_socratic;
			}
		}

		public String M1M_guidance(){
			if (spanish) {
				return sfM1M_guidance;
			} 
			else if (german){
				return gfM1M_guidance;
			}
			else {
				return fM1M_guidance;
			}
		}

		public String M1M_didacticConceptual(){
			if (spanish) {
				return sfM1M_didacticConceptual;
			} 
			else if (german){
				return gfM1M_didacticConceptual;
			}
			else {
				return fM1M_didacticConceptual;
			}
		}

		public String M1M_didacticProcedural(){
			if (spanish) {
				return sfM1M_didacticProcedural;
			} 
			else if (german){
				return gfM1M_didacticProcedural;
			}
			else {
				return fM1M_didacticProcedural;
			}
		}

		public String M2M_socratic(){
			if (spanish) {
				return sfM2M_socratic;
			} 
			else if (german){
				return gfM2M_socratic;
			}
			else {
				return fM2M_socratic;
			}
		}
		public String M2M_guidance(){
			if (spanish) {
				return sfM2M_guidance;
			} 
			else if (german){
				return gfM2M_guidance;
			}
			else {
				return fM2M_guidance;
			}
		}
		public String M2M_didacticConceptual(){
			if (spanish) {
				return sfM2M_didacticConceptual;
			} 
			else if (german){
				return gfM2M_didacticConceptual;
			}
			else {
				return fM2M_didacticConceptual;
			}
		}
		public String M2M_didacticProcedural(){
			if (spanish) {
				return sfM2M_didacticProcedural;
			} 
			else if (german){
				return gfM2M_didacticProcedural;
			}
			else {
				return fM2M_didacticProcedural;
			}
		}

		public String CM2M_socratic(){
			if (spanish) {
				return sfCM2M_socratic;
			} 
			else if (german){
				return gfCM2M_socratic;
			}
			else {
				return fCM2M_socratic;
			}
		}
		public String CM2M_guidance(){
			if (spanish) {
				return sfCM2M_guidance;
			} 
			else if (german){
				return gfCM2M_guidance;
			}
			else {
				return fCM2M_guidance;
			}
		}
		public String CM2M_didacticConceptual(){
			if (spanish) {
				return sfCM2M_didacticConceptual;
			} 
			else if (german){
				return gfCM2M_didacticConceptual;
			}
			else {
				return fCM2M_didacticConceptual;
			}
		}
		public String CM2M_didacticProcedural(){
			if (spanish) {
				return sfCM2M_didacticProcedural;
			} 
			else if (german){
				return gfCM2M_didacticProcedural;
			}
			else {
				return fCM2M_didacticProcedural;
			}
		}

		public String M3M_socratic(){
			if (spanish) {
				return sfM3M_socratic;
			} 
			else if (german){
				return gfM3M_socratic;
			}
			else {
				return fM3M_socratic;
			}
		}
		public String M3M_guidance(){
			if (spanish) {
				return sfM3M_guidance;
			} 
			else if (german){
				return gfM3M_guidance;
			}
			else {
				return fM3M_guidance;
			}
		}
		public String M3M_didacticConceptual(){
			if (spanish) {
				return sfM3M_didacticConceptual;
			} 
			else if (german){
				return gfM3M_didacticConceptual;
			}
			else {
				return fM3M_didacticConceptual;
			}
		}

		public String M4M_didacticConceptual(){
			if (spanish) {
				return sfM4M_didacticConceptual;
			} 
			else if (german){
				return gfM4M_didacticConceptual;
			}
			else {
				return fM4M_didacticConceptual;
			}
		}

		public String M5M_socratic(){
			if (spanish) {
				return sfM5M_socratic;
			} 
			else if (german){
				return gfM5M_socratic;
			}
			else {
				return fM5M_socratic;
			}
		}
		public String M5M_guidance(){
			if (spanish) {
				return sfM5M_guidance;
			} 
			else if (german){
				return gfM5M_guidance;
			}
			else {
				return fM5M_guidance;
			}
		}
		public String M5M_didacticConceptual(){
			if (spanish) {
				return sfM5M_didacticConceptual;
			} 
			else if (german){
				return gfM5M_didacticConceptual;
			}
			else {
				return fM5M_didacticConceptual;
			}
		}
		public String M5M_didacticProcedural(){
			if (spanish) {
				return sfM5M_didacticProcedural;
			} 
			else if (german){
				return gfM5M_didacticProcedural;
			}
			else {
				return fM5M_didacticProcedural;
			}
		}

		public String CM5M_socratic(){
			if (spanish) {
				return sfCM5M_socratic;
			} 
			else if (german){
				return gfCM5M_socratic;
			}
			else {
				return fCM5M_socratic;
			}
		}
		public String CM5M_guidance(){
			if (spanish) {
				return sfCM5M_guidance;
			} 
			else if (german){
				return gfCM5M_guidance;
			}
			else {
				return fCM5M_guidance;
			}
		}
		public String CM5M_didacticConceptual(){
			if (spanish) {
				return sfCM5M_didacticConceptual;
			} 
			else if (german){
				return gfCM5M_didacticConceptual;
			}
			else {
				return fCM5M_didacticConceptual;
			}
		}
		public String CM5M_didacticProcedural(){
			if (spanish) {
				return sfCM5M_didacticProcedural;
			} 
			else if (german){
				return gfCM5M_didacticProcedural;
			}
			else {
				return fCM5M_didacticProcedural;
			}
		}

		public String M6M_socratic(){
			if (spanish) {
				return sfM6M_socratic;
			} 
			else if (german){
				return gfM6M_socratic;
			}
			else {
				return fM6M_socratic;
			}
		}
		public String M6M_guidance(){
			if (spanish) {
				return sfM6M_guidance;
			} 
			else if (german){
				return gfM6M_guidance;
			}
			else {
				return fM6M_guidance;
			}
		}
		public String M6M_didacticConceptual(){
			if (spanish) {
				return sfM6M_didacticConceptual;
			} 
			else if (german){
				return gfM6M_didacticConceptual;
			}
			else {
				return fM6M_didacticConceptual;
			}
		}
		public String M6M_didacticProcedural(){
			if (spanish) {
				return sfM6M_didacticProcedural;
			} 
			else if (german){
				return gfM6M_didacticProcedural;
			}
			else {
				return fM6M_didacticProcedural;
			}
		}

		public String CM6M_socratic(){
			if (spanish) {
				return sfCM6M_socratic;
			} 
			else if (german){
				return gfCM6M_socratic;
			}
			else {
				return fCM6M_socratic;
			}
		}
		public String CM6M_guidance(){
			if (spanish) {
				return sfCM6M_guidance;
			} 
			else if (german){
				return gfCM6M_guidance;
			}
			else {
				return fCM6M_guidance;
			}
		}
		public String CM6M_didacticConceptual(){
			if (spanish) {
				return sfCM6M_didacticConceptual;
			} 
			else if (german){
				return gfCM6M_didacticConceptual;
			}
			else {
				return fCM6M_didacticConceptual;
			}
		}
		public String CM6M_didacticProcedural(){
			if (spanish) {
				return sfCM6M_didacticProcedural;
			} 
			else if (german){
				return gfCM6M_didacticProcedural;
			}
			else {
				return fCM6M_didacticProcedural;
			}
		}
			
		public String CM6MSecond_socratic(){
			if (spanish) {
				return sfCM6MSecond_socratic;
			} 
			else if (german){
				return gfCM6MSecond_socratic;
			}
			else {
				return fCM6MSecond_socratic;
			}
		}
		public String CM6MSecond_guidance(){
			if (spanish) {
				return sfCM6MSecond_guidance;
			} 
			else if (german){
				return gfCM6MSecond_guidance;
			}
			else {
				return fCM6MSecond_guidance;
			}
		}
		public String CM6MSecond_didacticConceptual(){
			if (spanish) {
				return sfCM6MSecond_didacticConceptual;
			} 
			else if (german){
				return gfCM6MSecond_didacticConceptual;
			}
			else {
				return fCM6MSecond_didacticConceptual;
			}
		}
		public String CM6MSecond_didacticProcedural(){
			if (spanish) {
				return sfCM6MSecond_didacticProcedural;
			} 
			else if (german){
				return gfCM6MSecond_didacticProcedural;
			}
			else {
				return fCM6MSecond_didacticProcedural;
			}
		}

		public String M7M_socratic(){
			if (spanish) {
				return sfM7M_socratic;
			} 
			else if (german){
				return gfM7M_socratic;
			}
			else {
				return fM7M_socratic;
			}
		}
		public String M7M_guidance(){
			if (spanish) {
				return sfM7M_guidance;
			} 
			else if (german){
				return gfM7M_guidance;
			}
			else {
				return fM7M_guidance;
			}
		}
		public String M7M_didacticConceptual(){
			if (spanish) {
				return sfM7M_didacticConceptual;
			} 
			else if (german){
				return gfM7M_didacticConceptual;
			}
			else {
				return fM7M_didacticConceptual;
			}
		}
		public String M7M_didacticProcedural(){
			if (spanish) {
				return sfM7M_didacticProcedural;
			} 
			else if (german){
				return gfM7M_didacticProcedural;
			}
			else {
				return fM7M_didacticProcedural;
			}
		}
			
		public String CM7M_socratic(){
			if (spanish) {
				return sfCM7M_socratic;
			} 
			else if (german){
				return gfCM7M_socratic;
			}
			else {
				return fCM7M_socratic;
			}
		}
		public String CM7M_guidance(){
			if (spanish) {
				return sfCM7M_guidance;
			} 
			else if (german){
				return gfCM7M_guidance;
			}
			else {
				return fCM7M_guidance;
			}
		}
		public String CM7M_didacticProcedural(){
			if (spanish) {
				return sfCM7M_didacticProcedural;
			} 
			else if (german){
				return gfCM7M_didacticProcedural;
			}
			else {
				return fCM7M_didacticProcedural;
			}
		}

		public String M8M_socratic(){
			if (spanish) {
				return sfM8M_socratic;
			} 
			else if (german){
				return gfM8M_socratic;
			}
			else {
				return fM8M_socratic;
			}
		}
		public String M8M_guidance(){
			if (spanish) {
				return sfM8M_guidance;
			} 
			else if (german){
				return gfM8M_guidance;
			}
			else {
				return fM8M_guidance;
			}
		}
		public String M8M_didacticConceptual(){
			if (spanish) {
				return sfM8M_didacticConceptual;
			} 
			else if (german){
				return gfM8M_didacticConceptual;
			}
			else {
				return fM8M_didacticConceptual;
			}
		}
		public String M8M_didacticProcedural(){
			if (spanish) {
				return sfM8M_didacticProcedural;
			} 
			else if (german){
				return gfM8M_didacticProcedural;
			}
			else {
				return fM8M_didacticProcedural;
			}
		}

		public String M9M_socratic(){
			if (spanish) {
				return sfM9M_socratic;
			} 
			else if (german){
				return gfM9M_socratic;
			}
			else {
				return fM9M_socratic;
			}
		}
		public String M9M_guidance(){
			if (spanish) {
				return sfM9M_guidance;
			} 
			else if (german){
				return gfM9M_guidance;
			}
			else {
				return fM9M_guidance;
			}
		}
		public String M9M_didacticConceptual(){
			if (spanish) {
				return sfM9M_didacticConceptual;
			} 
			else if (german){
				return gfM9M_didacticConceptual;
			}
			else {
				return fM9M_didacticConceptual;
			}
		}
		public String M9M_didacticProcedural(){
			if (spanish) {
				return sfM9M_didacticProcedural;
			} 
			else if (german){
				return gfM9M_didacticProcedural;
			}
			else {
				return fM9M_didacticProcedural;
			}
		}

		public String M10M_socratic(){
			if (spanish) {
				return sfM10M_socratic;
			} 
			else if (german){
				return gfM10M_socratic;
			}
			else {
				return fM10M_socratic;
			}
		}
		public String M10M_guidance(){
			if (spanish) {
				return sfM10M_guidance;
			} 
			else if (german){
				return gfM10M_guidance;
			}
			else {
				return fM10M_guidance;
			}
		}
		public String M10M_didacticConceptual(){
			if (spanish) {
				return sfM10M_didacticConceptual;
			} 
			else if (german){
				return gfM10M_didacticConceptual;
			}
			else {
				return fM10M_didacticConceptual;
			}
		}

		public String CM8M_socratic(){
			if (spanish) {
				return sfCM8M_socratic;
			} 
			else if (german){
				return gfCM8M_socratic;
			}
			else {
				return fCM8M_socratic;
			}
		}
		public String CM8M_guidance(){
			if (spanish) {
				return sfCM8M_guidance;
			} 
			else if (german){
				return gfCM8M_guidance;
			}
			else {
				return fCM8M_guidance;
			}
		}
		public String CM8M_didacticConceptual(){
			if (spanish) {
				return sfCM8M_didacticConceptual;
			} 
			else if (german){
				return gfCM8M_didacticConceptual;
			}
			else {
				return fCM8M_didacticConceptual;
			}
		}
		public String CM8M_didacticProcedural(){
			if (spanish) {
				return sfCM8M_didacticProcedural;
			} 
			else if (german){
				return gfCM8M_didacticProcedural;
			}
			else {
				return fCM8M_didacticProcedural;
			}
		}

		public String M11M_socratic(){
			if (spanish) {
				return sfM11M_socratic;
			} 
			else if (german){
				return gfM11M_socratic;
			}
			else {
				return fM11M_socratic;
			}
		} 
		public String M11M_guidance(){
			if (spanish) {
				return sfM11M_guidance;
			} 
			else if (german){
				return gfM11M_guidance;
			}
			else  {
				return fM11M_guidance;
			}
		}
		public String M11M_didacticConceptual(){
			if (spanish) {
				return sfM11M_didacticConceptual;
			} 
			else if (german){
				return gfM11M_didacticConceptual;
			}
			else {
				return fM11M_didacticConceptual;
			}
		}

		public String M12M_didacticConceptual(){
			if (spanish) {
				return sfM12M_didacticConceptual;
			} 
			else if (german){
				return gfM12M_didacticConceptual;
			}
			else {
				return fM12M_didacticConceptual;
			}
		}

		public String M13M_socratic(){
			if (spanish) {
				return sfM13M_socratic;
			} 
			else if (german){
				return gfM13M_socratic;
			}
			else {
				return fM13M_socratic;
			}
		}
		public String M13M_guidance(){
			if (spanish) {
				return sfM13M_guidance;
			} 
			else if (german){
				return gfM13M_guidance;
			}
			else {
				return fM13M_guidance;
			}
		}
		public String M13M_didacticConceptual(){
			if (spanish) {
				return sfM13M_didacticConceptual;
			} 
			else if (german){
				return gfM13M_didacticConceptual;
			}
			else {
				return fM13M_didacticConceptual;
			}
		}
			
		public String CM11M_didacticConceptual(){
			if (spanish) {
				return sfCM11M_didacticConceptual;
			} 
			else if (german){
				return gfCM11M_didacticConceptual;
			}
			else {
				return fCM11M_didacticConceptual;
			}
		}

		public String CM12M_socratic(){
			if (spanish) {
				return sfCM12M_socratic;
			} 
			else if (german){
				return gfCM12M_socratic;
			}
			else {
				return fCM12M_socratic;
			}
		}

		public String E1M_didacticConceptual(){
			if (spanish) {
				return sfE1M_didacticConceptual;
			} 
			else if (german){
				return gfE1M_didacticConceptual;
			}
			else {
				return fE1M_didacticConceptual;
			}
		}

		public String E2M_didacticConceptual(){
			if (spanish) {
				return sfE2M_didacticConceptual;
			} 
			else if (german){
				return gfE2M_didacticConceptual;
			}
			else {
				return fE2M_didacticConceptual;
			}
		}

		public String CE2M_didacticConceptual(){
			if (spanish) {
				return sfCE2M_didacticConceptual;
			} 
			else if (german){
				return gfCE2M_didacticConceptual;
			}
			else {
				return fCE2M_didacticConceptual;
			}
		}

		public String R1M_didacticConceptual(){
			if (spanish) {
				return sfR1M_didacticConceptual;
			} 
			else if (german) {
				return gfR1M_didacticConceptual;
			}
			else {
				return fR1M_didacticConceptual;
			}
		}

		public String R2M_didacticConceptual(){
			if (spanish) {
				return sfR2M_didacticConceptual;
			} 
			else if (german){
				return gfR2M_didacticConceptual;
			}
			else {
				return fR2M_didacticConceptual;
			}
		}

		public String O1M_didacticConceptual(){
			if (spanish) {
				return sfO1M_didacticConceptual;
			} 
			else if (german){
				return gfO1M_didacticConceptual;
			}
			else {
				return fO1M_didacticConceptual;
			}
		}

		public String O2M_didacticConceptual(){
			if (spanish) {
				return sfO2M_didacticConceptual;
			} 
			else if (german){
				return gfO2M_didacticConceptual;
			}
			else {
				return fO2M_didacticConceptual;
			}
		}

		public String MF6M_socratic(){
			if (spanish) {
				return sfMF6M_socratic;
			} 
			else if (german){
				return gfMF6M_socratic;
			}
			else {
				return fMF6M_socratic;
			}
		}
		public String MF6M_guidance(){
			if (spanish) {
				return sfMF6M_guidance;
			} 
			else if (german){
				return gfMF6M_guidance;
			}
			else {
				return fMF6M_guidance;
			}
		}

		public String MF10M_socratic(){
			if (spanish) {
				return sfMF10M_socratic;
			} 
			else if (german){
				return gfMF10M_socratic;
			}
			else {
				return fMF10M_socratic;
			}
		}

		public String MF11M_socratic(){
			if (spanish) {
				return sfMF11M_socratic;
			} 
			else if (german){
				return gfMF11M_socratic;
			}
			else {
				return fMF11M_socratic;
			}
		} 
		public String MF11M_guidance(){
			if (spanish) {
				return sfMF11M_guidance;
			} 
			else if (german){
				return gfMF11M_guidance;
			}
			else {
				return fMF11M_guidance;
			}
		}
			
		public String MF12M_socratic(){
			if (spanish) {
				return sfMF12M_socratic;
			} 
			else if (german){
				return gfMF12M_socratic;
			}
			else {
				return fMF12M_socratic;
			}
		}
		public String MF12M_guidance(){
			if (spanish) {
				return sfMF12M_guidance;
			} 
			else if (german){
				return gfMF12M_guidance;
			}
			else {
				return fMF12M_guidance;
			}
		}

		public String MFE1M_didacticConceptual(){
			if (spanish) {
				return sfMFE1M_didacticConceptual;
			} 
			else if (german){
				return gfMFE1M_didacticConceptual;
			}
			else {
				return fMFE1M_didacticConceptual;
			}
		}

		public String MFE2M_didacticConceptual(){
			if (spanish) {
				return sfMFE2M_didacticConceptual;
			} 
			else if (german){
				return gfMFE2M_didacticConceptual;
			}
			else {
				return fMFE2M_didacticConceptual;
			}
		} 

		public String F2M1M_socratic(){
			if (spanish) {
				return sfF2M1M_socratic;
			} 
			else if (german){
				return gfF2M1M_socratic;
			}
			else {
				return fF2M1M_socratic;
			}
		}
		public String F2M1M_guidance(){
			if (spanish) {
				return sfF2M1M_guidance;
			} 
			else if (german){
				return gfF2M1M_guidance;
			}
			else {
				return fF2M1M_guidance;
			}
		}
		public String F2M1M_didacticConceptual(){
			if (spanish) {
				return sfF2M1M_didacticConceptual;
			} 
			else if (german){
				return gfF2M1M_didacticConceptual;
			}
			else {
				return fF2M1M_didacticConceptual;
			}
		}
		public String F2M1M_didacticProcedural(){
			if (spanish) {
				return sfF2M1M_didacticProcedural;
			} 
			else if (german){
				return gfF2M1M_didacticProcedural;
			}
			else {
				return fF2M1M_didacticProcedural;
			}
		}

		public String F2M4M_socratic(){
			if (spanish) {
				return sfF2M4M_socratic;
			} 
			else if (german){
				return gfF2M4M_socratic;
			}
			else {
				return fF2M4M_socratic;
			}
		}

		public String F2M6M_socratic(){
			if (spanish) {
				return sfF2M6M_socratic;
			} 
			else if (german){
				return gfF2M6M_socratic;
			}
			else {
				return fF2M6M_socratic;
			}
		}
		public String F2M6M_guidance(){
			if (spanish) {
				return sfF2M6M_guidance;
			} 
			else if (german){
				return gfF2M6M_guidance;
			}
			else {
				return fF2M6M_guidance;
			}
		}
		public String F2M6M_didacticConceptual(){
			if (spanish) {
				return sfF2M6M_didacticConceptual;
			} 
			else if (german){
				return gfF2M6M_didacticConceptual;
			}
			else {
				return fF2M6M_didacticConceptual;
			}
		}
		public String F2M6M_didacticProcedural(){
			if (spanish) {
				return sfF2M6M_didacticProcedural;
			} 
			else if (german){
				return gfF2M6M_didacticProcedural;
			}
			else {
				return fF2M6M_didacticProcedural;
			}
		}

		public String F2M7M_socratic(){
			if (spanish) {
				return sfF2M7M_socratic;
			} 
			else if (german){
				return gfF2M7M_socratic;
			}
			else {
				return fF2M7M_socratic;
			}
		}
		public String F2M7M_guidance(){
			if (spanish) {
				return sfF2M7M_guidance;
			} 
			else if (german){
				return gfF2M7M_guidance;
			}
			else {
				return fF2M7M_guidance;
			}
		}
		public String F2M7M_didacticConceptual(){
			if (spanish) {
				return sfF2M7M_didacticConceptual;
			} 
			else if (german){
				return gfF2M7M_didacticConceptual;
			}
			else {
				return fF2M7M_didacticConceptual;
			}
		}
		public String F2M7M_didacticProcedural(){
			if (spanish) {
				return sfF2M7M_didacticProcedural;
			} 
			else if (german){
				return gfF2M7M_didacticProcedural;
			}
			else {
				return fF2M7M_didacticProcedural;
			}
		}

		public String F2M7bM_socratic(){
			if (spanish) {
				return sfF2M7bM_socratic;
			} 
			else if (german){
				return gfF2M7bM_socratic;
			}
			else {
				return fF2M7bM_socratic;
			}
		} 
		public String F2M7bM_guidance(){
			if (spanish) {
				return sfF2M7bM_guidance;
			} 
			else if (german){
				return gfF2M7bM_guidance;
			}
			else {
				return fF2M7bM_guidance;
			}
		}
		public String F2M7bM_didacticConceptual(){
			if (spanish) {
				return sfF2M7bM_didacticConceptual;
			} 
			else if (german){
				return gfF2M7bM_didacticConceptual;
			}
			else {
				return fF2M7bM_didacticConceptual;
			}
		}
		public String F2M7bM_didacticProcedural(){
			if (spanish) {
				return sfF2M7bM_didacticProcedural;
			} 
			else if (german){
				return gfF2M7bM_didacticProcedural;
			}
			else {
				return fF2M7bM_didacticProcedural;
			}
		}

		public String F2M7cM_socratic(){
			if (spanish) {
				return sfF2M7cM_socratic;
			} 
			else if (german){
				return gfF2M7cM_socratic;
			}
			else {
				return fF2M7cM_socratic;
			}
		}
		public String F2M7cM_guidance(){
			if (spanish) {
				return sfF2M7cM_guidance;
			} 
			else if (german){
				return gfF2M7cM_guidance;
			}
			else {
				return fF2M7cM_guidance;
			}
		}
		public String F2M7cM_didacticConceptual(){
			if (spanish) {
				return sfF2M7cM_didacticConceptual;
			} 
			else if (german){
				return gfF2M7cM_didacticConceptual;
			}
			else {
				return fF2M7cM_didacticConceptual;
			}
		}
		public String F2M7cM_didacticProcedural(){
			if (spanish) {
				return sfF2M7cM_didacticProcedural;
			} 
			else if (german){
				return gfF2M7cM_didacticProcedural;
			}
			else {
				return fF2M7cM_didacticProcedural;
			}
		}

		public String F2M10M_socratic(){
			if (spanish) {
				return sfF2M10M_socratic;
			} 
			else if (german){
				return gfF2M10M_socratic;
			}
			else {
				return fF2M10M_socratic;
			}
		}

		public String F2M11M_socratic(){
			if (spanish) {
				return sfF2M11M_socratic;
			} 
			else if (german){
				return gfF2M11M_socratic;
			}
			else {
				return fF2M11M_socratic;
			}
		}
		public String F2M11M_guidance(){
			if (spanish) {
				return sfF2M11M_guidance;
			} 
			else if (german){
				return gfF2M11M_guidance;
			}
			else {
				return fF2M11M_guidance;
			}
		}

		public String MF2E1M_didacticConceptual(){
			if (spanish) {
				return sfMF2E1M_didacticConceptual;
			} 
			else if (german){
				return gfMF2E1M_didacticConceptual;
			}
			else {
				return fMF2E1M_didacticConceptual;
			}
		}

		public String MF2E2M_didacticConceptual(){
			if (spanish) {
				return sfMF2E2M_didacticConceptual;
			} 
			else if (german){
				return gfMF2E2M_didacticConceptual;
			}
			else {
				return fMF2E2M_didacticConceptual;
			}
		}

		
		public String T24M1M_socratic(){
			if (spanish) {
				return sfT24M1M_socratic;
			} 
			else if (german){
				return gfT24M1M_socratic;
			}
			else {
				return fT24M1M_socratic;
			}
		} 
		public String T24M1M_guidance(){
			if (spanish) {
				return sfT24M1M_guidance;
			} 
			else if (german){
				return gfT24M1M_guidance;
			}
			else {
				return fT24M1M_guidance;
			}
		}
		public String T24M1M_didacticConceptual(){
			if (spanish) {
				return sfT24M1M_didacticConceptual;
			} 
			else if (german){
				return gfT24M1M_didacticConceptual;
			}
			else {
				return fT24M1M_didacticConceptual;
			}
		}
		public String T24M1M_didacticProcedural(){
			if (spanish) {
				return sfT24M1M_didacticProcedural;
			} 
			else if (german){
				return gfT24M1M_didacticProcedural;
			}
			else {
				return fT24M1M_didacticProcedural;
			}
		}

		public String T24M2M_socratic(){
			if (spanish) {
				return sfT24M2M_socratic;
			} 
			else if (german){
				return gfT24M2M_socratic;
			}
			else {
				return fT24M2M_socratic;
			}
		}
		public String T24M2M_guidance(){
			if (spanish) {
				return sfT24M2M_guidance;
			} 
			else if (german){
				return gfT24M2M_guidance;
			}
			else {
				return fT24M2M_guidance;
			}
		}
		public String T24M2M_didacticConceptual(){
			if (spanish) {
				return sfT24M2M_didacticConceptual;
			} 
			else if (german){
				return gfT24M2M_didacticConceptual;
			}
			else {
				return fT24M2M_didacticConceptual;
			}
		}
		public String T24M2M_didacticProcedural(){
			if (spanish) {
				return sfT24M2M_didacticProcedural;
			} 
			else if (german){
				return gfT24M2M_didacticProcedural;
			}
			else {
				return fT24M2M_didacticProcedural;
			}
		}

		public String T24M3M_socratic(){
			if (spanish) {
				return sfT24M3M_socratic;
			} 
			else if (german){
				return gfT24M3M_socratic;
			}
			else {
				return fT24M3M_socratic;
			}
		}
		public String T24M3M_guidance(){
			if (spanish) {
				return sfT24M3M_guidance;
			} 
			else if (german){
				return gfT24M3M_guidance;
			}
			else {
				return fT24M3M_guidance;
			}
		}
		public String T24M3M_didacticConceptual(){
			if (spanish) {
				return sfT24M3M_didacticConceptual;
			} 
			else if (german){
				return gfT24M3M_didacticConceptual;
			}
			else {
				return fT24M3M_didacticConceptual;
			}
		}

		public String T24M4M_didacticConceptual(){
			if (spanish) {
				return sfT24M4M_didacticConceptual;
			} 
			else if (german){
				return gfT24M4M_didacticConceptual;
			}
			else {
				return fT24M4M_didacticConceptual;
			}
		}

		public String T24M5M_socratic(){
			if (spanish) {
				return sfT24M5M_socratic;
			} 
			else if (german){
				return gfT24M5M_socratic;
			}
			else {
				return fT24M5M_socratic;
			}
		}
		public String T24M5M_guidance(){
			if (spanish) {
				return sfT24M5M_guidance;
			} 
			else if (german){
				return gfT24M5M_guidance;
			}
			else {
				return fT24M5M_guidance;
			}
		}
		public String T24M5M_didacticConceptual(){
			if (spanish) {
				return sfT24M5M_didacticConceptual;
			} 
			else if (german){
				return gfT24M5M_didacticConceptual;
			}
			else {
				return fT24M5M_didacticConceptual;
			}
		}
		public String T24M5M_didacticProcedural(){
			if (spanish) {
				return sfT24M5M_didacticProcedural;
			} 
			else if (german){
				return gfT24M5M_didacticProcedural;
			}
			else {
				return fT24M5M_didacticProcedural;
			}
		}

		public String T24M6M_socratic(){
			if (spanish) {
				return sfT24M6M_socratic;
			} 
			else if (german){
				return gfT24M6M_socratic;
			}
			else {
				return fT24M6M_socratic;
			}
		}
		public String T24M6M_guidance(){
			if (spanish) {
				return sfT24M6M_guidance;
			} 
			else if (german){
				return gfT24M6M_guidance;
			}
			else {
				return fT24M6M_guidance;
			}
		}
		public String T24M6M_didacticConceptual(){
			if (spanish) {
				return sfT24M6M_didacticConceptual;
			} 
			else if (german){
				return gfT24M6M_didacticConceptual;
			}
			else {
				return fT24M6M_didacticConceptual;
			}
		}
		public String T24M6M_didacticProcedural(){
			if (spanish) {
				return sfT24M6M_didacticProcedural;
			} 
			else if (german){
				return gfT24M6M_didacticProcedural;
			}
			else {
				return fT24M6M_didacticProcedural;
			}
		}

		public String T24M7M_socratic(){
			if (spanish) {
				return sfT24M7M_socratic;
			} 
			else if (german){
				return gfT24M7M_socratic;
			}
			else {
				return fT24M7M_socratic;
			}
		}
		public String T24M7M_guidance (){
			if (spanish) {
				return sfT24M7M_guidance;
			} 
			else if (german){
				return gfT24M7M_guidance;
			}
			else {
				return fT24M7M_guidance;
			}
		}
		public String T24M7M_didacticConceptual(){
			if (spanish) {
				return sfT24M7M_didacticConceptual;
			} 
			else if (german){
				return gfT24M7M_didacticConceptual;
			}
			else {
				return fT24M7M_didacticConceptual;
			}
		}
		public String T24M7M_didacticProcedural(){
			if (spanish) {
				return sfT24M7M_didacticProcedural;
			} 
			else if (german){
				return gfT24M7M_didacticProcedural;
			}
			else {
				return fT24M7M_didacticProcedural;
			}
		}

		public String T24M8M_socratic(){
			if (spanish) {
				return sfT24M8M_socratic;
			} 
			else if (german){
				return gfT24M8M_socratic;
			}
			else {
				return fT24M8M_socratic;
			}
		}
		public String T24M8M_guidance(){
			if (spanish) {
				return sfT24M8M_guidance;
			} 
			else if (german){
				return gfT24M8M_guidance;
			}
			else {
				return fT24M8M_guidance;
			}
		}
		public String T24M8M_didacticConceptual(){
			if (spanish) {
				return sfT24M8M_didacticConceptual;
			} 
			else if (german){
				return gfT24M8M_didacticConceptual;
			}
			else {
				return fT24M8M_didacticConceptual;
			}
		}

		public String T24M9M_socratic(){
			if (spanish) {
				return sfT24M9M_socratic;
			} 
			else if (german){
				return gfT24M9M_socratic;
			}
			else {
				return fT24M9M_socratic;
			}
		}
		public String T24M9M_guidance(){
			if (spanish) {
				return sfT24M9M_guidance;
			} 
			else if (german){
				return gfT24M9M_guidance;
			}
			else {
				return fT24M9M_guidance;
			}
		}
		public String T24M9M_didacticConceptual(){
			if (spanish) {
				return sfT24M9M_didacticConceptual;
			} 
			else if (german){
				return gfT24M9M_didacticConceptual;
			}
			else {
				return fT24M9M_didacticConceptual;
			}
		}
			
		public String T24M10M_didacticConceptual(){
			if (spanish) {
				return sfT24M10M_didacticConceptual;
			} 
			else if (german){
				return gfT24M10M_didacticConceptual;
			}
			else {
				return fT24M10M_didacticConceptual;
			}
		}

		public String T24M11M_socratic(){
			if (spanish) {
				return sfT24M11M_socratic;
			} 
			else if (german){
				return gfT24M11M_socratic;
			}
			else {
				return fT24M11M_socratic;
			}
		}
		public String T24M11M_guidance(){
			if (spanish) {
				return sfT24M11M_guidance;
			} 
			else if (german){
				return gfT24M11M_guidance;
			}
			else {
				return fT24M11M_guidance;
			}
		}
		public String T24M11M_didacticConceptual(){
			if (spanish) {
				return sfT24M11M_didacticConceptual;
			} 
			else if (german){
				return gfT24M11M_didacticConceptual;
			}
			else {
				return fT24M11M_didacticConceptual;
			}
		}

		public String T24M12M_socratic(){
			if (spanish) {
				return sfT24M12M_socratic;
			} 
			else if (german){
				return gfT24M12M_socratic;
			}
			else {
				return fT24M12M_socratic;
			}
		}
		public String T24M12M_guidance(){
			if (spanish) {
				return sfT24M12M_guidance;
			} 
			else if (german){
				return gfT24M12M_guidance;
			}
			else {
				return fT24M12M_guidance;
			}
		}
		public String T24M12M_didacticConceptual(){
			if (spanish) {
				return sfT24M12M_didacticConceptual;
			} 
			else if (german){
				return gfT24M12M_didacticConceptual;
			}
			else {
				return fT24M12M_didacticConceptual;
			}
		}
		public String T24M12M_didacticProcedural(){
			if (spanish) {
				return sfT24M12M_didacticProcedural;
			} 
			else if (german){
				return gfT24M12M_didacticProcedural;
			}
			else {
				return fT24M12M_didacticProcedural;
			}
		}

		public String T24M13M_socratic(){
			if (spanish) {
				return sfT24M13M_socratic;
			} 
			else if (german){
				return gfT24M13M_socratic;
			}
			else {
				return fT24M13M_socratic;
			}
		}
		public String T24M13M_guidance(){
			if (spanish) {
				return sfT24M13M_guidance;
			} 
			else if (german){
				return gfT24M13M_guidance;
			}
			else {
				return fT24M13M_guidance;
			}
		}
		public String T24M13M_didacticConceptual(){
			if (spanish) {
				return sfT24M13M_didacticConceptual;
			} 
			else if (german){
				return gfT24M13M_didacticConceptual;
			}
			else {
				return fT24M13M_didacticConceptual;
			}
		}
		public String T24M13M_didacticProcedural(){
			if (spanish) {
				return sfT24M13M_didacticProcedural;
			} 
			else if (german){
				return gfT24M13M_didacticProcedural;
			}
			else {
				return fT24M13M_didacticProcedural;
			}
		} 

		public String T24E1M_didacticConceptual(){
			if (spanish) {
				return sfT24E1M_didacticConceptual;
			} 
			else if (german){
				return gfT24E1M_didacticConceptual;
			}
			else {
				return fT24E1M_didacticConceptual;
			}
		}

		public String T24E2M_didacticConceptual(){
			if (spanish) {
				return sfT24E2M_didacticConceptual;
			} 
			else if (german){
				return gfT24E2M_didacticConceptual;
			}
			else {
				return fT24E2M_didacticConceptual;
			}
		}

		
		
		public String T26M1M_guidance(){
			if (spanish) {
				return sfT26M1M_guidance;
			} 
			else if (german){
				return gfT26M1M_guidance;
			}
			else {
				return fT26M1M_guidance;
			}
		}
		public String T26M1M_socratic(){
			if (spanish) {
				return sfT26M1M_socratic;
			} 
			else if (german){
				return gfT26M1M_socratic;
			}
			else {
				return fT26M1M_socratic;
			}
		}
		public String T26M1M_didacticConceptual(){
			if (spanish) {
				return sfT26M1M_didacticConceptual;
			} 
			else if (german){
				return gfT26M1M_didacticConceptual;
			}
			else {
				return fT26M1M_didacticConceptual;
			}
		}
		public String T26M1M_didacticProcedural(){
			if (spanish) {
				return sfT26M1M_didacticProcedural;
			} 
			else if (german){
				return gfT26M1M_didacticProcedural;
			}
			else {
				return fT26M1M_didacticProcedural;
			}
		}

		public String T26M2M_guidance(){
			if (spanish) {
				return sfT26M2M_guidance;
			} 
			else if (german){
				return gfT26M2M_guidance;
			}
			else {
				return fT26M2M_guidance;
			}
		}
		public String T26M2M_socratic(){
			if (spanish) {
				return sfT26M2M_socratic;
			} 
			else if (german){
				return gfT26M2M_socratic;
			}
			else {
				return fT26M2M_socratic;
			}
		}
		public String T26M2M_didacticConceptual(){
			if (spanish) {
				return sfT26M2M_didacticConceptual;
			} 
			else if (german){
				return gfT26M2M_didacticConceptual;
			}
			else {
				return fT26M2M_didacticConceptual;
			}
		}
		public String T26M2M_didacticProcedural(){
			if (spanish) {
				return sfT26M2M_didacticProcedural;
			} 
			else if (german){
				return gfT26M2M_didacticProcedural;
			}
			else {
				return fT26M2M_didacticProcedural;
			}
		}
			
		public String T26M3M_guidance(){
			if (spanish) {
				return sfT26M3M_guidance;
			} 
			else if (german){
				return gfT26M3M_guidance;
			}
			else {
				return fT26M3M_guidance;
			}
		} 
		public String T26M3M_socratic(){
			if (spanish) {
				return sfT26M3M_socratic;
			} 
			else if (german){
				return gfT26M3M_socratic;
			}
			else {
				return fT26M3M_socratic;
			}
		}
		public String T26M3M_didacticConceptual(){
			if (spanish) {
				return sfT26M3M_didacticConceptual;
			} 
			else if (german){
				return gfT26M3M_didacticConceptual;
			}
			else {
				return fT26M3M_didacticConceptual;
			}
		}

		public String T26M4M_didacticConceptual(){
			if (spanish) {
				return sfT26M4M_didacticConceptual;
			} 
			else if (german){
				return gfT26M4M_didacticConceptual;
			}
			else {
				return fT26M4M_didacticConceptual;
			}
		}

		public String T26M5M_guidance(){
			if (spanish) {
				return sfT26M5M_guidance;
			} 
			else if (german){
				return gfT26M5M_guidance;
			}
			else {
				return fT26M5M_guidance;
			}
		}
		public String T26M5M_socratic(){
			if (spanish) {
				return sfT26M5M_socratic;
			} 
			else if (german){
				return gfT26M5M_socratic;
			}
			else {
				return fT26M5M_socratic;
			}
		}
		public String T26M5M_didacticConceptual(){
			if (spanish) {
				return sfT26M5M_didacticConceptual;
			} 
			else if (german){
				return gfT26M5M_didacticConceptual;
			}
			else {
				return fT26M5M_didacticConceptual;
			}
		}
		public String T26M5M_didacticProcedural(){
			if (spanish) {
				return sfT26M5M_didacticProcedural;
			} 
			else if (german){
				return gfT26M5M_didacticProcedural;
			}
			else {
				return fT26M5M_didacticProcedural;
			}
		}

		public String T26M6M_guidance(){
			if (spanish) {
				return sfT26M6M_guidance;
			} 
			else if (german){
				return gfT26M6M_guidance;
			}
			else {
				return fT26M6M_guidance;
			}
		}
		public String T26M6M_socratic(){
			if (spanish) {
				return sfT26M6M_socratic;
			} 
			else if (german){
				return gfT26M6M_socratic;
			}
			else {
				return fT26M6M_socratic;
			}
		}
		public String T26M6M_didacticConceptual(){
			if (spanish) {
				return sfT26M6M_didacticConceptual;
			} 
			else if (german){
				return gfT26M6M_didacticConceptual;
			}
			else {
				return fT26M6M_didacticConceptual;
			}
		}
		public String T26M6M_didacticProcedural(){
			if (spanish) {
				return sfT26M6M_didacticProcedural;
			} 
			else if (german){
				return gfT26M6M_didacticProcedural;
			}
			else {
				return fT26M6M_didacticProcedural;
			}
		}

		public String T26M7M_guidance (){
			if (spanish) {
				return sfT26M7M_guidance;
			} 
			else if (german){
				return gfT26M7M_guidance;
			}
			else {
				return fT26M7M_guidance;
			}
		}
		public String T26M7M_socratic(){
			if (spanish) {
				return sfT26M7M_socratic;
			} 
			else if (german) {
				return gfT26M7M_socratic;
			}
			else {
				return fT26M7M_socratic;
			}
		}
		public String T26M7M_didacticConceptual(){
			if (spanish) {
				return sfT26M7M_didacticConceptual;
			} 
			else if (german){
				return gfT26M7M_didacticConceptual;
			}
			else {
				return fT26M7M_didacticConceptual;
			}
		}
		public String T26M7M_didacticProcedural(){
			if (spanish) {
				return sfT26M7M_didacticProcedural;
			} 
			else if (german){
				return gfT26M7M_didacticProcedural;
			}
			else {
				return fT26M7M_didacticProcedural;
			}
		}

		public String T26M8M_guidance(){
			if (spanish) {
				return sfT26M8M_guidance;
			} 
			else if (german){
				return gfT26M8M_guidance;
			}
			else {
				return fT26M8M_guidance;
			}
		}
		public String T26M8M_socratic(){
			if (spanish) {
				return sfT26M8M_socratic;
			} 
			else if (german){
				return gfT26M8M_socratic;
			}
			else {
				return fT26M8M_socratic;
			}
		}
		public String T26M8M_didacticConceptual(){
			if (spanish) {
				return sfT26M8M_didacticConceptual;
			} 
			else if (german){
				return gfT26M8M_didacticConceptual;
			}
			else {
				return fT26M8M_didacticConceptual;
			}
		}

		public String T26M10M_didacticConceptual(){
			if (spanish) {
				return sfT26M10M_didacticConceptual;
			} 
			else if (german){
				return gfT26M10M_didacticConceptual;
			}
			else {
				return fT26M10M_didacticConceptual;
			}
		}

		public String T26M11M_guidance(){
			if (spanish) {
				return sfT26M11M_guidance;
			} 
			else if (german){
				return gfT26M11M_guidance;
			}
			else {
				return fT26M11M_guidance;
			}
		}
		public String T26M11M_socratic(){
			if (spanish) {
				return sfT26M11M_socratic;
			} 
			else if (german){
				return gfT26M11M_socratic;
			}
			else {
				return fT26M11M_socratic;
			}
		}
		public String T26M11M_didacticConceptual(){
			if (spanish) {
				return sfT26M11M_didacticConceptual;
			} 
			else if (german){
				return gfT26M11M_didacticConceptual;
			}
			else {
				return fT26M11M_didacticConceptual;
			}
		}
			
		public String T26E1M_didacticConceptual(){
			if (spanish) {
				return sfT26E1M_didacticConceptual;
			} 
			else if (german){
				return gfT26E1M_didacticConceptual;
			}
			else {
				return fT26E1M_didacticConceptual;
			}
		}

		public String T26E2M_didacticConceptual(){
			if (spanish) {
				return sfT26E2M_didacticConceptual;
			} 
			else if (german){
				return gfT26E2M_didacticConceptual;
			}
			else {
				return fT26E2M_didacticConceptual;
			}
		}

		
		
		public String T3aP1M1M_socratic(){
			if (spanish) {
				return sfT3aP1M1M_socratic;
			} 
			else if (german){
				return gfT3aP1M1M_socratic;
			}
			else {
				return fT3aP1M1M_socratic;
			}
		} 
		public String T3aP1M1M_guidance(){
			if (spanish) {
				return sfT3aP1M1M_guidance;
			} 
			else if (german){
				return gfT3aP1M1M_guidance;
			}
			else {
				return fT3aP1M1M_guidance;
			}
		}
		public String T3aP1M1M_didacticConceptual(){
			if (spanish) {
				return sfT3aP1M1M_didacticConceptual;
			} 
			else if (german){
				return gfT3aP1M1M_didacticConceptual;
			}
			else {
				return fT3aP1M1M_didacticConceptual;
			}
		}
		public String T3aP1M1M_didacticProcedural(){
			if (spanish) {
				return sfT3aP1M1M_didacticProcedural;
			} 
			else if (german){
				return gfT3aP1M1M_didacticProcedural;
			}
			else {
				return fT3aP1M1M_didacticProcedural;
			}
		}
			
		public String T3aP1M2M_socratic(){
			if (spanish) {
				return sfT3aP1M2M_socratic;
			} 
			else if (german){
				return gfT3aP1M2M_socratic;
			}
			else {
				return fT3aP1M2M_socratic;
			}
		} 
		public String T3aP1M2M_guidance(){
			if (spanish) {
				return sfT3aP1M2M_guidance;
			} 
			else if (german){
				return gfT3aP1M2M_guidance;
			}
			else {
				return fT3aP1M2M_guidance;
			}
		}
		public String T3aP1M2M_didacticConceptual(){
			if (spanish) {
				return sfT3aP1M2M_didacticConceptual;
			} 
			else if (german){
				return gfT3aP1M2M_didacticConceptual;
			}
			else {
				return fT3aP1M2M_didacticConceptual;
			}
		}
		public String T3aP1M2M_didacticProcedural(){
			if (spanish) {
				return sfT3aP1M2M_didacticProcedural;
			} 
			else if (german){
				return gfT3aP1M2M_didacticProcedural;
			}
			else {
				return fT3aP1M2M_didacticProcedural;
			}
		} 

		public String T3aP1M3M_socratic(){
			if (spanish) {
				return sfT3aP1M3M_socratic;
			} 
			else if (german){
				return gfT3aP1M3M_socratic;
			}
			else {
				return fT3aP1M3M_socratic;
			}
		}
		public String T3aP1M3M_guidance(){
			if (spanish) {
				return sfT3aP1M3M_guidance;
			} 
			else if (german){
				return gfT3aP1M3M_guidance;
			}
			else {
				return fT3aP1M3M_guidance;
			}
		}
		public String T3aP1M3M_didacticConceptual(){
			if (spanish) {
				return sfT3aP1M3M_didacticConceptual;
			} 
			else if (german){
				return gfT3aP1M3M_didacticConceptual;
			}
			else {
				return fT3aP1M3M_didacticConceptual;
			}
		}

		public String T3aP1M4M_didacticConceptual(){
			if (spanish) {
				return sfT3aP1M4M_didacticConceptual;
			} 
			else if (german){
				return gfT3aP1M4M_didacticConceptual;
			}
			else {
				return fT3aP1M4M_didacticConceptual;
			}
		}

		public String T3aP1M5M_socratic(){
			if (spanish) {
				return sfT3aP1M5M_socratic;
			} 
			else if (german){
				return gfT3aP1M5M_socratic;
			}
			else {
				return fT3aP1M5M_socratic;
			}
		}
		public String T3aP1M5M_guidance(){
			if (spanish) {
				return sfT3aP1M5M_guidance;
			} 
			else if (german){
				return gfT3aP1M5M_guidance;
			}
			else {
				return fT3aP1M5M_guidance;
			}
		}
		public String T3aP1M5M_didacticConceptual(){
			if (spanish) {
				return sfT3aP1M5M_didacticConceptual;
			} 
			else if (german){
				return gfT3aP1M5M_didacticConceptual;
			}
			else {
				return fT3aP1M5M_didacticConceptual;
			}
		}
		public String T3aP1M5M_didacticProcedural(){
			if (spanish) {
				return sfT3aP1M5M_didacticProcedural;
			} 
			else if (german){
				return gfT3aP1M5M_didacticProcedural;
			}
			else {
				return fT3aP1M5M_didacticProcedural;
			}
		} 

		public String T3aP1M6M_socratic(){
			if (spanish) {
				return sfT3aP1M6M_socratic;
			} 
			else if (german){
				return gfT3aP1M6M_socratic;
			}
			else {
				return fT3aP1M6M_socratic;
			}
		}
		public String T3aP1M6M_guidance(){
			if (spanish) {
				return sfT3aP1M6M_guidance;
			} 
			else if (german){
				return gfT3aP1M6M_guidance;
			}
			else {
				return fT3aP1M6M_guidance;
			}
		}
		public String T3aP1M6M_didacticConceptual(){
			if (spanish) {
				return sfT3aP1M6M_didacticConceptual;
			} 
			else if (german){
				return gfT3aP1M6M_didacticConceptual;
			}
			else {
				return fT3aP1M6M_didacticConceptual;
			}
		}
		public String T3aP1M6M_didacticProcedural(){
			if (spanish) {
				return sfT3aP1M6M_didacticProcedural;
			} 
			else if (german){
				return gfT3aP1M6M_didacticProcedural;
			}
			else {
				return fT3aP1M6M_didacticProcedural;
			}
		}

		public String T3aP1M7M_socratic(){
			if (spanish) {
				return sfT3aP1M7M_socratic;
			} 
			else if (german){
				return gfT3aP1M7M_socratic;
			}
			else {
				return fT3aP1M7M_socratic;
			}
		}
		public String T3aP1M7M_guidance(){
			if (spanish) {
				return sfT3aP1M7M_guidance;
			} 
			else if (german){
				return gfT3aP1M7M_guidance;
			}
			else {
				return fT3aP1M7M_guidance;
			}
		}

		public String T3aP1M8M_socratic(){
			if (spanish) {
				return sfT3aP1M8M_socratic;
			} 
			else if (german){
				return gfT3aP1M8M_socratic;
			}
			else {
				return fT3aP1M8M_socratic;
			}
		}
		public String T3aP1M8M_guidance(){
			if (spanish) {
				return sfT3aP1M8M_guidance;
			} 
			else if (german){
				return gfT3aP1M8M_guidance;
			}
			else {
				return fT3aP1M8M_guidance;
			}
		}

		public String T3aP1M10M_didacticConceptual(){
			if (spanish) {
				return sfT3aP1M10M_didacticConceptual;
			} 
			else if (german){
				return gfT3aP1M10M_didacticConceptual;
			}
			else {
				return fT3aP1M10M_didacticConceptual;
			}
		} 

		public String T3aP1M11M_socratic(){
			if (spanish) {
				return sfT3aP1M11M_socratic;
			} 
			else if (german){
				return gfT3aP1M11M_socratic;
			}
			else {
				return fT3aP1M11M_socratic;
			}
		}
		public String T3aP1M11M_guidance(){
			if (spanish) {
				return sfT3aP1M11M_guidance;
			} 
			else if (german){
				return gfT3aP1M11M_guidance;
			}
			else {
				return fT3aP1M11M_guidance;
			}
		}
		public String T3aP1M11M_didacticConceptual(){
			if (spanish) {
				return sfT3aP1M11M_didacticConceptual;
			} 
			else if (german){
				return gfT3aP1M11M_didacticConceptual;
			}
			else {
				return fT3aP1M11M_didacticConceptual;
			}
		}

		public String T3aP1E1M_didacticConceptual(){
			if (spanish) {
				return sfT3aP1E1M_didacticConceptual;
			} 
			else if (german){
				return gfT3aP1E1M_didacticConceptual;
			}
			else {
				return fT3aP1E1M_didacticConceptual;
			}
		} 

		public String T3aP1E2M_didacticConceptual(){
			if (spanish) {
				return sfT3aP1E2M_didacticConceptual;
			} 
			else if (german){
				return gfT3aP1E2M_didacticConceptual;
			}
			else {
				return fT3aP1E2M_didacticConceptual;
			}
		} 
			




	}
}

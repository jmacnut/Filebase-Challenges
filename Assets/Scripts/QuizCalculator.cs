using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
   [SerializeField]
   private int _numOfQuizzes = 5;

   [SerializeField]
   private List<float> _gradesList = new List<float>();

   void Start()
   {
      // generate quiz grades
      GenerateQuizGrades(_numOfQuizzes);
   }

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         float averageGrade = 0.0f;
         string finalGrade = "";

         averageGrade = CalculateAverageGrade();
         finalGrade = CalculateLetterGrade(averageGrade);
         Debug.Log("Average Points = " + averageGrade.ToString("n2") + ", " +
            "       Final Grade is " + finalGrade);
      }
   }

   private void GenerateQuizGrades(int numQuizzes)
   {
      for (int i = 0; i < numQuizzes; i++)
      {
         _gradesList.Add(Random.Range(0, 100));
      }
   }

   private float CalculateAverageGrade()
   {
      float totalGrade = 0;
      float avgGrade = 0;


      // calculate average of grades
      foreach (var grade in _gradesList)
      {
         totalGrade += grade;
      }

      avgGrade = totalGrade / _numOfQuizzes;

      return avgGrade;
   }

   private string CalculateLetterGrade(float avgGrade)
   {
      string letterGrade = "";

      switch (avgGrade)
      {
         case var _ when avgGrade >= 90:
            letterGrade = "A";
            break;
         case var _ when avgGrade >= 80:
            letterGrade = "B";
            break;
         case var _ when avgGrade >= 70:
            letterGrade = "C";
            break;
         case var _ when avgGrade < 70:
            letterGrade = "F";
            break;
      }

      return letterGrade;
   }

}

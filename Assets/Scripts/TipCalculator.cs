using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
   [SerializeField]
   private float _bill;

   [SerializeField]
   private List<float> _tipList = new List<float>();

   [SerializeField]
   private float _customTipAmount;

   private void Start()
   {
      _tipList.Add(0.15f);
      _tipList.Add(0.20f);
      _tipList.Add(0.25f);
   }

   void Update()
   {
      if (_customTipAmount > 1.0f)
      {
         _customTipAmount /= 100f;
      }

      Debug.Log("Your bill is $ " + _bill.ToString("c2"));

      foreach (var tip in _tipList)
      {
         CalculateBill(_bill, tip, false);
      }

      CalculateBill(_bill, _customTipAmount, true);
   }

   private void CalculateBill(float bill, float tip, bool custom)
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         if (!custom)
         {
            Debug.Log((tip * 100) + "% tip = " + (bill * tip).ToString("c2") +
            " with a final total of: " + ((bill * tip) + bill).ToString("c2"));
         }
         else
         {
            Debug.Log("Your custom tip of " + (_customTipAmount * 100) + "% = " +
                      (_bill * _customTipAmount).ToString("c2") +
                      " with a final total of " +
                      ((_bill * _customTipAmount) + _bill).ToString("c2"));
         }
      }

   }
}

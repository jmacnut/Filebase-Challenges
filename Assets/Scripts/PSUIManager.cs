using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PSUIManager : MonoBehaviour
{
   [SerializeField]
   private PlayerStats playerStats;

   [SerializeField]
   private Text playerName;
   [SerializeField]
   private Text attackLevel;
   [SerializeField]
   private Text magicLevel;
   [SerializeField]
   private Text smithingLevel;
   [SerializeField]
   private Text miningLevel;

   private void Start()
   {
      playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
      //textField = GameObject.Find("Player_Name_Text").GetComponent<Text>();
      playerName.text = "Player Name: " + playerStats.playerName;
      attackLevel.text = "Attack Level: " + playerStats.attackLevel;
      magicLevel.text = "Magic Level: " + playerStats.magicLevel;
      smithingLevel.text = "Smithing Level: " + playerStats.smithingLevel;
      miningLevel.text = "Mining Level: " + playerStats.miningLevel;
   }
}

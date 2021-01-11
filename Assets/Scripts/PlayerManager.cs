using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{
    
        public static PlayerManager Instance { get; private set; }

        public string playerName;

        //Abilities
        public float strength;
        public float dexterity;
        public float constitution;
        public float intelligence;
        public float wisdom;
        public float charisma;

        public string race;
        public string playerClass;
        public string alignment;

        public int currentXp;
        public int maxXp;
        public int currentHp;
        public int maxHp;
        public int armorClass;
        public int walkingSpeed;
        public int runningSpeed;
        public int jumpHeight;
        public List<string> items;

        //Awake Method
        private void Awake() {
                if(Instance == null) {
                        Instance = this;
                        DontDestroyOnLoad(gameObject);
                }
                else {
                        Destroy(gameObject);
                }
        }    

}

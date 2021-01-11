using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class DataManager : MonoBehaviour
{
    
        public static DataManager Instance { get; private set; }

        public string jsonText;

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

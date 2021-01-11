using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRoll : MonoBehaviour
{

    public Text jsonField;

    void Start() {
        jsonField.text = DataManager.Instance.jsonText;
    }

}

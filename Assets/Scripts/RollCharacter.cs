using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
using UnityEngine.UI;

public class RollCharacter : MonoBehaviour
{

    public Text textField;

    public Text jsonText;

    public InputField nameField;
    public Dropdown raceField;
    public Dropdown classField;
    public Dropdown alignmentField;
    public InputField CurrXpField;
    public InputField MaxXpField;
    public InputField CurrHpField;
    public InputField MaxHpField;
    public InputField ArmorField;
    public InputField WalkingField;
    public InputField RunningField;
    public InputField JumpingField;
    public Text strengthVal;
    public Text dexterityVal;
    public Text constitutionVal;
    public Text intelligenceVal;
    public Text wisdomVal;
    public Text charismaVal;

    public void setText() {

        int num = roll();
        textField.text = num.ToString();

    }
 
    public int roll() {

        int value;

        List<int> d6List = new List<int>();
        List<int> d4List = new List<int>();

        d6List.Add(UnityEngine.Random.Range(1, 7));
        d6List.Add(UnityEngine.Random.Range(1, 7));
        d6List.Add(UnityEngine.Random.Range(1, 7));

        d4List.Add(UnityEngine.Random.Range(1, 5));
        d4List.Add(UnityEngine.Random.Range(1, 5));
        d4List.Add(UnityEngine.Random.Range(1, 5));

        d6List.Sort();
        d4List.Sort();

        d6List.RemoveAt(0);
        d4List.RemoveAt(0);

        value = d6List.Sum() + d4List.Sum() + 2;
        return value;
    }

    public void makeCharacterBtn() {

        PlayerManager.Instance.playerName = nameField.text;
        PlayerManager.Instance.race = raceField.options[raceField.value].text;
        PlayerManager.Instance.playerClass = classField.options[classField.value].text;
        PlayerManager.Instance.alignment = alignmentField.options[alignmentField.value].text;
        PlayerManager.Instance.currentXp = Int32.Parse(CurrXpField.text);
        PlayerManager.Instance.maxXp = Int32.Parse(MaxXpField.text);
        PlayerManager.Instance.currentHp = Int32.Parse(CurrHpField.text);
        PlayerManager.Instance.maxHp = Int32.Parse(MaxHpField.text);
        PlayerManager.Instance.armorClass = Int32.Parse(ArmorField.text);
        PlayerManager.Instance.walkingSpeed = Int32.Parse(WalkingField.text);
        PlayerManager.Instance.runningSpeed = Int32.Parse(RunningField.text);
        PlayerManager.Instance.jumpHeight = Int32.Parse(JumpingField.text);
        PlayerManager.Instance.strength = Int32.Parse(strengthVal.text);
        PlayerManager.Instance.dexterity = Int32.Parse(dexterityVal.text);
        PlayerManager.Instance.constitution = Int32.Parse(constitutionVal.text);
        PlayerManager.Instance.intelligence = Int32.Parse(intelligenceVal.text);
        PlayerManager.Instance.wisdom = Int32.Parse(wisdomVal.text);
        PlayerManager.Instance.charisma = Int32.Parse(charismaVal.text);

        Save();

    }

    public void Save() {
        string json = JsonUtility.ToJson(PlayerManager.Instance);
        jsonText.text = json;
        DataManager.Instance.jsonText = json;
    }

}

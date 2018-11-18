using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayTimer : MonoBehaviour {
    Image fillImg;
    public float timeAmount = 20f;
    float time;
    public Text timeText;

	// Use this for initialization
	void Start () {
        fillImg = this.GetComponent<Image>();
        time = timeAmount;
	}
	
	// Update is called once per frame
	void Update () {
        if (time > 0)
        {
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmount;
            timeText.text = "Time: " + time.ToString("f");
        }
		
	}
}

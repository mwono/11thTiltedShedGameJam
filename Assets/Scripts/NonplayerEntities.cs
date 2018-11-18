using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonplayerEntities : MonoBehaviour {
    public GameObject UI;
    public int score;

    Collider2D coll;
    AudioSource src;
	// Use this for initialization
	void Start () {
        coll = this.gameObject.GetComponent<CircleCollider2D>();
        src = this.GetComponent<AudioSource>();
	}

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            src.Play();
            UI.GetComponent<UIManager>().updateScore(score);
            this.GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(src.clip.length);
            this.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonplayerEntities : MonoBehaviour {
    public GameObject UI;
    public int score;

    AudioSource clip;

    private void Start()
    {
        clip = this.gameObject.GetComponent<AudioSource>();
    }

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            clip.Play();
            UI.GetComponent<UIManager>().updateScore(score);
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(clip.clip.length);
            this.gameObject.SetActive(false);
        }
    }
}

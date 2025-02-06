using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCreaction : MonoBehaviour
{
    public Canvas reactionCanvas; 
    public Image reactionImage; 
    public Sprite[] reactionSprites;  
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        reactionCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        if (distance < 3f)
        {
            ShowReaction();
        }
        else
        {
            reactionCanvas.gameObject.SetActive(false);
        }
    }

    void ShowReaction()
    {
        reactionCanvas.gameObject.SetActive(true);
        reactionImage.sprite = reactionSprites[Random.Range(0, reactionSprites.Length)];
    }
}

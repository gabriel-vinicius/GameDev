using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] private Text textCoins;
    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            collectionSoundEffect.Play();
            DestroyObject(collision.gameObject);
            coins++;
            textCoins.text = "Coins: " + coins;
        }
    }
}

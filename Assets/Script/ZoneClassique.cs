using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneClassique : MonoBehaviour
{
    private int piano = 0;
    private int livre = 0;
    [SerializeField] GameManager _gameManager;
    [SerializeField] AudioClip _sonsPiano;
    [SerializeField] AudioClip _sonsLivre;
    [SerializeField] AudioClip _sonsCDClassique;
    void Update()
    {
        if (piano == 1 && livre == 1)
        {
            _gameManager.PlacerObjectFinal();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "piano")
        {
            piano = 1;
            GestAudio.instance.JouerEffetSonore(_sonsPiano);// Jouer le son
            other.gameObject.SetActive(false);
        }
        if (other.tag == "livre")
        {
            livre = 1;
            GestAudio.instance.JouerEffetSonore(_sonsLivre);// Jouer le son
            other.gameObject.SetActive(false);
        }
        if (other.tag == "CDClassique")
        {
            _gameManager.OuvrirPorte();
            GestAudio.instance.JouerEffetSonore(_sonsCDClassique);// Jouer le son
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
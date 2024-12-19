using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneRock : MonoBehaviour
{
    private int bracelet = 0;
    private int guitare = 0;
    [SerializeField] GameManager _gameManager;
    [SerializeField] AudioClip _sonsBracelet;
    [SerializeField] AudioClip _sonsGuitare;
    [SerializeField] AudioClip _sonsCDRock;

    void Update()
    {
        if (bracelet == 1 && guitare == 1)
        {
            _gameManager.PlacerObjectFinal();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bracelet")
        {
            bracelet = 1;
            GestAudio.instance.JouerEffetSonore(_sonsBracelet);// Jouer le son
            other.gameObject.SetActive(false);
        }
        if (other.tag == "guitare")
        {
            guitare = 1;
            GestAudio.instance.JouerEffetSonore(_sonsGuitare);// Jouer le son
            other.gameObject.SetActive(false);
        }
        if (other.tag == "CDRock")
        {
            _gameManager.OuvrirPorte();
            GestAudio.instance.JouerEffetSonore(_sonsCDRock);// Jouer le son
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
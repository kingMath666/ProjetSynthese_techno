using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneSalsa : MonoBehaviour
{
    private int maracas = 0;
    private int cigar = 0;
    [SerializeField] GameManager _gameManager;
    [SerializeField] AudioClip _sonsMaracas;
    [SerializeField] AudioClip _sonsCigar;
    [SerializeField] AudioClip _sonsCDSalsa;
    void Update()
    {
        if (maracas == 1 && cigar == 1)
        {
            _gameManager.PlacerObjectFinal();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "maracas")
        {
            maracas = 1;
            GestAudio.instance.JouerEffetSonore(_sonsMaracas);// Jouer le son
            other.gameObject.SetActive(false);
        }
        if (other.tag == "cigar")
        {
            cigar = 1;
            GestAudio.instance.JouerEffetSonore(_sonsCigar);// Jouer le son
            other.gameObject.SetActive(false);
        }
        if (other.tag == "CDSalsa")
        {
            _gameManager.OuvrirPorte();
            GestAudio.instance.JouerEffetSonore(_sonsCDSalsa);// Jouer le son
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
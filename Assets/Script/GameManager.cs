using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<Vector3> _listPos = new List<Vector3>();
    [SerializeField] GameObject cam;
    private int score = 0;
    private int finalScore = 0;
    [SerializeField] GameObject cdRock;
    [SerializeField] GameObject cdSalsa;
    [SerializeField] GameObject cdClassique;
    [SerializeField] GameObject porte;
    private GameObject rock;
    private GameObject salsa;
    private GameObject classique;
    void Start()
    {
        // rock = cdRock.GetComponent<GameObject>();
        // salsa = cdSalsa.GetComponent<GameObject>();
        // classique = cdClassique.GetComponent<GameObject>();
        cdRock.gameObject.SetActive(false);
        cdSalsa.gameObject.SetActive(false);
        cdClassique.gameObject.SetActive(false);
    }
    void Update()
    {
        // changer la positon en y de cam
        cam.transform.position = new Vector3(cam.transform.position.x, 1.02f, cam.transform.position.z);
    }

    public void PlacerObjectFinal()
    {
        score++;
        if (score == 3)
        {
            cdRock.gameObject.SetActive(true);
            cdSalsa.gameObject.SetActive(true);
            cdClassique.gameObject.SetActive(true);
        }
    }
    public void OuvrirPorte()
    {
        finalScore++;
        if (finalScore == 3)
        {
            Debug.Log("Ouverture de la porte");
            porte.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            porte.gameObject.transform.position = new Vector3(-34.314f, -0.2000003f, -1.769f);
        }
    }
}
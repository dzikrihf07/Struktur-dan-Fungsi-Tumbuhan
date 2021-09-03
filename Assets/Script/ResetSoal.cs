using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSoal : MonoBehaviour
{
    public GameObject Waktu, GameOver, Soal, Menang;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt ("skor", 0);
        Waktu.gameObject.SetActive(true);
        GameOver.gameObject.SetActive(false);
        Soal.gameObject.SetActive(false);
        Menang.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

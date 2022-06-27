using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class HesaplamaScript : MonoBehaviour
{
    public AudioSource seskaynak;
    public AudioClip mouseclick;
    public GameObject HesaplamaPaneli;
    float hesaplamakismi;
    public TextMeshProUGUI hesaplayazi;

    public void cikis()
    {
        Application.Quit();
        seskaynak.PlayOneShot(mouseclick);
    }
    public void secimekrani()
    {
        SceneManager.LoadScene(1);
        seskaynak.PlayOneShot(mouseclick);
    }
    public void nesneekrani2d()
    {
        SceneManager.LoadScene(6);
        seskaynak.PlayOneShot(mouseclick);
    }
    public void nesneekrani3d()
    {
        SceneManager.LoadScene(2);
        seskaynak.PlayOneShot(mouseclick);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
        seskaynak.PlayOneShot(mouseclick);
    }
    public void OyunEkrani2()
    {
        SceneManager.LoadScene(3);
        seskaynak.PlayOneShot(mouseclick);
    }
    public void OyunEkrani3()
    {
        SceneManager.LoadScene(4);
        seskaynak.PlayOneShot(mouseclick);
    }
    public void OyunEkrani4()
    {
        SceneManager.LoadScene(5);
        seskaynak.PlayOneShot(mouseclick);
    }
    public void OyunEkrani2d1()
    {
        SceneManager.LoadScene(7);
        seskaynak.PlayOneShot(mouseclick);
    }
    public void OyunEkrani2d2()
    {
        SceneManager.LoadScene(8);
        seskaynak.PlayOneShot(mouseclick);
    }
    public void oyunbitti()
    {
        SceneManager.LoadScene(9);
        seskaynak.PlayOneShot(mouseclick);
    }
    public void HesaplaPaneli()
    {
        HesaplamaPaneli.SetActive(true);
        seskaynak.PlayOneShot(mouseclick);
    }
    
}

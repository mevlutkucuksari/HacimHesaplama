using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class hesaplama : MonoBehaviour
{
    public string sayi1;
    public string sayi2;
    public string sayi3;
    public int sonuc;
    public float sonucfloat;


    public Text sayi1Text;
    public Text sayi2Text;
    public Text sayi3Text;
    public TextMeshProUGUI sonucText;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sayi1 = sayi1Text.text;
        sayi2 = sayi2Text.text;
        sayi3 = sayi3Text.text;
    }

    public void dikdortgen()
    {
        sonuc = int.Parse(sayi1) * int.Parse(sayi2) * int.Parse(sayi3);
        sonucText.text = sonuc.ToString();
    }
    public void kare()
    {
        sonuc = int.Parse(sayi1) * int.Parse(sayi1) * int.Parse(sayi1);
        sonucText.text = sonuc.ToString();
    }
    public void kure()
    {
        sonuc = (int.Parse(sayi1) * int.Parse(sayi1) * int.Parse(sayi1));
        sonucfloat= sonuc * 3 * 1.25f;
        sonucText.text = sonucfloat.ToString();
    }
    public void silindir()
    {
        sonuc = int.Parse(sayi1) * int.Parse(sayi1)*int.Parse(sayi2)*3;
        
        sonucText.text = sonuc.ToString();
    }
    public void kare2d()
    {
        sonuc = int.Parse(sayi1) * int.Parse(sayi1);

        sonucText.text = sonuc.ToString();
    }
    public void dikdortgen2d()
    {
        sonuc = int.Parse(sayi1) * int.Parse(sayi2);

        sonucText.text = sonuc.ToString();
    }
    public void cember()
    {
        sonuc = int.Parse(sayi1) * int.Parse(sayi1) *3;

        sonucText.text = sonuc.ToString();
    }
}

using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Readme : ScriptableObject
{
    public StyleSheet commonStyle;
    public StyleSheet darkStyle;
    public StyleSheet lightStyle;
    public Texture2D icon;
    public string title;
    public Section[] sections;
    public bool loadedLayout;

    [Serializable]
    public class Section
    {
        public string heading, text, linkText, url;
    }

    //Oyunumuzun amacı yeterli puanı toplayarak (şu an 50) bitişe gitmek. Kırmızı orblar -5 puan, yeşil orblar +10 puan verir.
    //PlayerManager scriptimiz karakterimizin hareket etmesini(kontrollerini), fizik ayarlamalarını, puan orblarıyla etkileşimimizi ve toplam puanın takibini sağlar.
    // Finish scriotimiz ise bize oyunu bitirmemizin için gerekli puan belirler, oyunu bitirince tekrar başlamamızı sağlar.

    //



}

# Vize_Projesi
Oyunumuzun amacı yeterli puanı toplayarak (şu an 50) bitişe gitmek. Kırmızı orblar -5 puan, yeşil orblar +10 puan verir.

PlayerManager scriptimiz karakterimizin hareket etmesini(kontrollerini), fizik ayarlamalarını, puan orblarıyla etkileşimimizi ve toplam puanın takibini sağlar.
Finish scriotimiz ise bize oyunu bitirmemizin için gerekli puan belirler, oyunu bitirince tekrar başlamamızı sağlar.

Score yazmak için kodlama yakarken ilginç bir hata ile karşılaştım. Hatanın fotoğrafını PDF e ekledim. Oyunu başlatınca hata sayısı 1 den 999+ ya gidiyordu. Hatanın tam kaynağını çözemedim ama ekrana Score yazdırmaya çalıştığım için olduğunu anladım. TestMeshPro dan kaynaklı bir sorun. Kodlarımda hata gözükmesede kendisi kafayı yedi. Çözüm olarak her şeyi sildim ve ekrana Score yazdırmak yerine Console üzerinden Score takibi ayarladım.

Oyuncu => Yeşil Top alır => Score +10 artar                                                   => Puan Yeterlidir Oyun biter ve yeniden başlar
⬆      ↓                                       ==> Oyuncu toplam puanı ile Bitiş yerine gelir
⬆      ==> Kırmızı Top alır => Score -5 azalır                                                => Puan Yetersizdir  ↓
⬆                                      ⬅                                         ⬅                               ⬅

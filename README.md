# Operatorok

A *kifejelzesek.txt* forrásállomány soraiban aritmetikai kifejezések találhatók a következő leírás szerint:

- Soronként a z első adat a kifejezés első operandusa. Feltételezheti, hogy egész számra alakítható.
- A második adat szöveges típusú, maximum három karakter hosszúságú. Az operátort határozza meg! Lehet olyan eset, hogy az operátor nem értelmezhető aritmetikai operátorként.
- A harmadik adat a kifejezés második operandusa. Feltételezheti, hogy egész számra alakítható.
- Az adatokat szóközökkel választottuk el, például:

![alt text](https://i.imgur.com/a0eNUMp.png "példa")

Készítsen konzolos alkalmazást (projektet) a következő feladatok megoldásához, melynek projektjét Operátorok néven mentse el!

1. Olvassa be a *kifejezesek.txt* állomány sorait és tárolja az adatokat egy olyan összetett adatszerkezetben (pol. vektor, lista stb.), amely használatával a további feladatok megoldhatók!
2. Határozza meg és írja ki a képernyőre, hogy az állomány hány kifejezést tartalmaz!
3. A maradékos osztás operátorát a mod szóval jelöltük az állományban. Határozza meg és írja a képernyőre a maradékos osztást tartalmazó kifejezések számát!
4. Döntse el, hogy a forrásállományban található-e olyan kifejezés, amelyben mindkét operandus maradék nélkül osztható tízzel! Az eldöntés eredményét írja a képernyőre! A keresést ne folytassa, ha a választ meg tudja adni!
5. Az egész osztás operátorát a div szóval jelöltük az állományban. Készítsen statisztikát az összeadás(+), kivonás(-), szorzás(\*), valós osztás(/), egész osztás(div) és maradékos osztás(mod) operátorokat tartalmazó kifejezések számáról!
6. Készítsen szöveges típusú adattal visszatérő függvényt, metódust vagy jellemzőt a kifejezések értékének meghatározására! A függvény az előző feladatban felsorolt operátorokat tudja kezelni, ismeretlen operátor esetén térjen vissza a "Hibás operátor!" üzenettel! Helyes operátor esetén sem lehet egy kifejezés értékét midnig meghatározni (pl. túlcsordulűás, nullával való osztás stb.), ilyen esetben a függvény térjen vissza az "Egyéb hiba!" üzenettel!
7. Kérjen be a felhasználótól egy kifejezést, amiről feltételezheti, hogy a forrás állományban lévő kifejezések leírásának megfelel!  Határozza meg az előző feladatban definiált függvény felhasználásával a kifejezés értékét, majd írja ki azt a minták szerint! A feladatot ismételje a "vége" inputig!
8. Készítse szöveges állományt *eredmenyek.txt* néven a minta szerint, melyben meghatározza a forrásállományban lévő kifejezések eredményeit!

Minta konzolablak:

![alt text](https://i.imgur.com/UHbIV9v.png "minta konzolablak")

Minta *eredmenyek.txt* állomány:

![alt text](https://i.imgur.com/syFhekE.png "minta eredmenyek.txt")

### - Add new card

`AddNewCard(card:ICard)` yang method ini digunakan untuk menambah kartu baru. nambahnya gimana?, bisa pake banyak cara, nanti kamu mau nambah satu-satu atau sekalian banyak. bisa pake cara generate card secara random kaya yang diajarin mas kinara kemarin. di dalam method ini itu nyimpen parameter yang isinya ICard, kenapa pake interface? yah biar flexibel aja sih misal dipake buat library yang lain gitu.

nah ini cara nambah kartunya misal kamu panggil dari `Program.cs`

```cs
class Program{
    static void Main(){
        Card card = new Card();
        GameController gameController = new GameController();
        // ngisi nama kartu
        card.SetCardName("Nama kartu");
        // ngisi card energy
        card.SetCardEnergy(3)
        /*misal mau set energynya jadi 3*/
        card.SetCardPower(3)
        /*misal mau set powernya jadi 3
         terus panggil methodnya buat ngeset, parameter nya kasih card yang sudah di set sebelumnya*/
        gameController.AddNewCard(card)
    }
}
```

terus isi dari game controllernya gunanya buat ngisi List cardnya


nanti isi dari `ICard card` kan udah ada isinya, tinggal di add aja di game controller kan ada variable `- _card:List<ICard>` ke listnya kaya gini misalnya

```cs
public bool AddNewCard(ICard card){
    _card.Add(card);
}
```


### - Remove card
`RemoveCard(card:ICard)` method ini dipake buat remove card. caranya sama sih kaya nge add cman yah tinggal di buat sama dengan null. ini cara pakenya dan di panggil dari `Program.cs`
kaya gini kan 

```cs
class Program{
    static void Main(){
        Card card = new Card();
        GameController gameController = new GameController();

        /*misal mau remove cardnya*/
        /*ibaratkan card sudah ada isinya dan kamu pengen hapus*/
        GameController().RemoveCard(card);
    }
}
```

terus di `GameController.cs` bisa diisi kaya gini
. kamu bisa buat logic untuk nyari `card` itu ada ga di `List card` nya. kalo ada nanti di hapus. kalo gaada berarti di skip aja misal dibikin `foreach` kaya gini 
```cs
public bool RemoveCard(card:ICard){
    foreach(ICard card_check in card){
        if(card_check == card){
            card.Remove();
        }
        else{
            // bisa dikasih something buat nandain kalo card gaada di list
        }
    }
}
```

### - Get card info
`GetCardInfo(card:ICard):IEnumerable<string>` nah kenapa dia mengembalikan `IEnumerable<string>`? nah kan kita mau get info, yang pasti kita harus mengembalikan list of string kan? seperti nama energy dan lain sebagainya.

### - List all card
ini buat mengembalikan semua list card yang sudah di add. misal ngisi di game controller kaya gini. ini aku bikin returnnya IEnumerable karena pengen kembalikan list cardnya dalam bentuk string. tapi kalo kamu mau rubah misal mau kembalikan `card` juga gapapa sama saja.

```cs
IEnumerable<string> ListAllCard(){
    /* trus bkin IEnumerable untuk dapetin semua list card dari `List<card>` */

}
```

### - Add new card to player

nah `AddNewCardToPlayer(player:IPlayer, card:ICard):bool` itu digunain buat ngisi stok `card` ke playernya. misal dalam satu game kan setiap player dapat 12 kartu tuh. nah method ini digunain buat itu. cardnya ditampung di player info yah bukan di playernya langsung. misal kayak gini. dia bakal ngakses dictionary ini ` _playerInfo:Dictionary<IPlayer,PlayerInfo>`

bikin logic buat nyari playernya kira-kira ada gak di dalam dictionarynya, bisa pake foreach kayak diatas
```cs
PlayerInfo playerInfo = new();
bool AddNewCardToPlayer(player:IPlayer, card:ICard){
    foreach(var kvp in _playerInfo){
        if(kvp.Key == player){
            playerInfo = kvp.Value;
            playerInfo.AddCardToDeck(card);
        }
    }
}
```

### - Pop card from player
ini digunain buat ngambil 1 kartu dari player, ini ibaratnya kita mau taru kartu di location kan harus ngambil satu dari playernya. nah ini method nya buat jalanin itu. caranya yah sama kaya nge add, tapi ini di ganti remove aja gitu


### - List all card from location
ini buat check card yang sudah di taro di location, methodnya gimana? sama seperti cara sebelumnya tinggal kita list aja returnya kan ICard.

### - Add new card to location
ini buat ngisi kartu ke lokasinya, yah seperti dalam game, kita mau lempar kartu ke lokasinya. makanya parameternya ada 3 `ILocation,IPlayer,ICard` buat jadi parameter siapa playernya, apa kartunya dan mau taro di lokasinya.


yah kurang lebih kaya gitu muwehehehehe
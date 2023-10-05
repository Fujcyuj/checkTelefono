# Luca Check Telefono

Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano ovvero:
- che inizia con +39 (esattamente lungo  13)
- oppure con 0039 (esattamente lungo 14)
- oppure con un 3 (esattamente lungo 10)

Se il numero non viene trovato, ritornare stringa vuota ""

Ad esempio.
Se arriva "05417373", "3367726712",  "778823"
Tornare "3367726712"

Se arriva "33677267", "33677232",  "778823"
Tornare ""

etc

-------------------------------------------------------------------------------------------------------------------------------

All'interno del file checkTelefono.cs c'è scritto il codice di controllo.

I numeri vengono inviati come vettori a grippi di 3 quindi vengono suddivisi in sottovettori e elaborati singolarmente usando il comando seguente:
foreach( string input in inputStr )
dove la stringa input è il sottovettore del vettore inputStr.

Per essere sicuri che il numero inizi con le cifre giuste viene eseguito un if dove di controllno i primi valori della stringa, per esempio:
if( input.StartsWith("0039") )
Se la stringa non inizia con le seguenti cifre verrà scartato automaticamente e il foreach passerà alla stringa successiva.

Se invece l'inizio della stringa è corretto passerà al secondo controllo per determinare la lunghezza, per esempio:
if( input.Length == 14 )
Se la lunghezza è diversa la stringa verrà scartata e ricomincerà il ciclo.

Invece se è corretta passerà alluntimo controllo che serve per determinare che allinterno ci siano solo numeri e non altro.
bool eUnNumero = Int64.TryParse( input, out valore );
Il valore bool eUnNumero controlla che il valore inserito sia effettivamente un numero.
Viene usato Int64 perchè il valore è troppo grande e il classico Int lo riconoscerebbe come una stringa.

Alla fine se il  if( eUnNumero ) è vero, il valore in input verrà mostrato. return input;
Se anche un solo controllo risultasse falso ritornerà NULL: return ""; Che viene inserito alla fine del codice.

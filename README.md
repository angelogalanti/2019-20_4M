# 2019-20_4M
Repository di Informatica della classe 4M


## [Link](https://script.google.com/macros/s/AKfycbx3Mn36N3G4CfGV-ju_NDdMtc9tr9-tkwm4Md-Xrei6GoYffiAs/exec) **per fare l'upload delle verifiche**

[Link](https://docs.google.com/document/d/1kOz3-40qowkA11BvfyNgN8kR9aijXcTVZm4Y3wl0xD4/edit?usp=sharing) **Verifica 8/11/19**

## [Link](https://docs.google.com/document/d/1xgcI_vC2KKHlk8-1fHTsrljq0jJsOBPXKFEcXeMKWXs/edit?usp=sharing) **Verifica 24/01/19**

## [Link](https://docs.google.com/document/d/1qGkCy6RHydsXZS8TcWLtMGOdlpoIxiKRC1E6MP8Pxeg/edit?usp=sharing) **Recupero Verifica 28/01/19**



## Introduzione
- [concetti fondamentali dell'informatica](http://aptiva.v2.cs.unibo.it/wiki/index.php/Concetti_fondamentali_dell%27Informatica)

## Ingegneria del SW
Vai al mercato e compra un litro di latte, se hanno le uova prendine sei
![](https://swaltersky.files.wordpress.com/2012/02/tire-swing-cartoon.jpg)

## Diagrammi delle classi
![](diagramma%20della%20classe%20ContoCorrente.jpg)

**Esercizio: Officine** <br>
Produrre il diagramma UML corrispondente ad un'applicazione riguardante un insieme di officine,
facendo riferimento alle seguenti specifiche:
• Delle officine interessano: nome, indirizzo, numero di dipendenti, dipendenti (con l'informazione
su quanti anni di servizio), e direttore. Si noti che ogni officina ha uno ed un solo direttore.
• Dei dipendenti e dei direttori interessano: codice fiscale, indirizzo, numeri di telefono.
• Ogni riparazione è effettuata da una ed una sola officina, e riguarda uno ed un solo veicolo. Di ogni riparazione interessano: codice (univoco nell'ambito dell'officina), ora e data di accettazione del veicolo, e, nel caso di riparazione terminata, ora e data di riconsegna del veicolo.
• Dei veicoli interessano: modello, tipo, targa, anno di immatricolazione, e proprietario. Ogni veicolo ha uno ed un solo proprietario.
• Dei proprietari di veicoli interessano: codice fiscale, indirizzo, e numeri di telefono.


**Esercizio: Dipartimenti Aziendali** <br>
Una certa azienda è costituita da diversi dipartimenti, ad ognuno dei quali afferisce un certo insieme di impiegati. Ogni impiegato (del quale interessa il nome, l’età, lo stipendio) afferisce esattamente ad un dipartimento. Dei dipartimenti interessa il nome, il numero di telefono, ed il direttore. Gli impiegati partecipano a vari progetti aziendali, dei quali interessa il nome ed il budget. 

**Esercizio: Ristorante** <br>
In un ristorante sono entità di interesse i clienti, i tavoli (con il relativo numero di posti), le prenotazioni (effettuate dai clienti per un certo giorno ed ora, ed un certo numero di persone) alle quali viene assegnato uno o più tavoli, i camerieri (che servono i clienti al tavolo) ed i conti relativi ai vari tavoli (contenenti i prezzi delle singole portate ordinate, e le loro quantità).Dei clienti interessa il nome e numero di telefono, mentre dei camerieri interessa nome e anni di servizio.Infine delle portate interessa il nome ed il prezzo unitario.

**Esercizio: Università** <br>
Degli studenti interessa il numero di matricola, la data di nascita, il luogo di nascita (città e regione), la facoltà in cui è iscritto (con l’anno di iscrizione), e i corsi superati.
Dei professori interessa il nome, la data di nascita, Il luogo di nascita e il corso insegnato.
Delle facoltà interessa il nome ed il tipo (scientifica, letteraria, ecc..).
Dei corsi interessa il codice, il numero di ore di lezione, e la facoltà a cui appartiene.

**Esercizio UML Polizia Urbana** <br>
L'applicazione da progettare riguarda le informazioni sulle contravvenzioni elevate in un comune. Di ogni contravvenzione interessa il veicolo a cui è stata effettuata, il vigile che l'ha elevata, il numero di verbale e il luogo in cui è stata elevata. Di ogni vigile interessa il nome, il cognome ed il numero di matricola. Di ogni veicolo interessa la targa. Esistono matricola. Di ogni veicolo interessa la targa. Esistono solamente due categorie di veicoli, che sono fra loro disgiunte: automobili e motocicli. Delle automobili interessa la potenza in kilowatt, dei motocicli il numero di telaio. Sappiamo che il comune vuole effettuare, come cliente della nostra applicazione, dei controlli sul lavoro del proprio personale. In particolare, si deve progettare il diagramma delle classi in modo che, dato un vigile, il comune possa controllare se un vigile ha elevato una contravvenzione per più di una volta ad uno stesso veicolo. 

**Esercizio UML Officine** <br>
Le officine riparano i veicoli. Di ogni officina interessano il nome, l’indirizzo, il numero di dipendenti, i dipendenti (con l'informazione su quanti anni di servizio ciascun dipendente ha svolto presso l’officina), ed il direttore (unico). Si noti che un dipendente lavora presso una ed una sola officina, e che un direttore dirige una ed una sola officina, e non è anche un dipendente (e vice-versa). Dei dipendenti e dei direttori interessano: il codice fiscale, l'indirizzo ed il numero telefono. interessano: il codice fiscale, l'indirizzo ed il numero telefono. Dei direttori interessa anche l'età. Di ogni riparazione interessa: il codice, l’officina presso cui è eseguita, il veicolo oggetto della riparazione, l’ora e la data di accettazione, e, per le riparazioni portate a termine, l’ora e la data di riconsegna. Di ogni veicolo interessano: il modello, il tipo, la targa, l’anno di immatricolazione, ed il proprietario. Dei proprietari interessa codice fiscale, l’indirizzo, ed il numero telefono. Si noti che il proprietario di un veicolo riparato può essere anche un dipendente o il direttore di un’officina. 
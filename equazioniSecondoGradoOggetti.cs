//ESERCIZIO EQUAZIONI DI SECONDO GRADO USANDO GLI OGGETTI
//classe
EquazioneDiSecondoGrado
// attributi
double a,b,c,x1,x2,delta;
string casiDelta; // "2 sol distinte" "2 sol coincidenti" "impossibile"
// costruttore
void EquazioneDiSecondoGrado(double a, double b, double c);
// medodi
double calcolaDelta();
void calcolaSoluzioni(); //-->  calcolaDelta() --> x1 , x2
string TipologiaDiSoluzione(); // casiDelta -->  calcolaDelta()
double[] getSoluzioni();

// medodiAggiuntivi
void setA(double a);
void setB(double b);
void setC(double c);

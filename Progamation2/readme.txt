Jeu de la vie-------------
Url     : http://codes-sources.commentcamarche.net/source/53719-jeu-de-la-vieAuteur  : epineurienDate    : 03/08/2013
Licence :
=========

Ce document intitulé « Jeu de la vie » issu de CommentCaMarche
(codes-sources.commentcamarche.net) est mis à disposition sous les termes de
la licence Creative Commons. Vous pouvez copier, modifier des copies de cette
source, dans les conditions fixées par la licence, tant que cette note
apparaît clairement.

Description :
=============

Une impl&eacute;mentation en C# du jeu de la vie, illustrant certaines m&eacute;
thodes permettant de gagner en rapidit&eacute; d'ex&eacute;cution :
<br />- Uti
lisation du ThreadPooling pour traiter en parall&egrave;le de grandes quantit&ea
cute;s de donn&eacute;es.
<br />- Cr&eacute;ation de graphisme directement &agr
ave; partir d'un tampon d'octets.
<br />Cette impl&eacute;mentation permet auss
i de charger ses propres &quot;formes&quot; et d'observer leur comportement.
<b
r />
<br />Divers :
<br />- La vitesse est limit&eacute; &agrave; 100 g&eacute
;n&eacute;ration / secondes.
<br />- Si une cellule vivante est entour&eacute;e
 par 2 ou 3 cellules vivantes elle survie, sinon elle meurt.
<br />- Si une cel
lule morte est entour&eacute;e par 2 cellules vivantes, elle revit.
<br />- Le 
tiers central est laiss&eacute; vide pour laisser place &agrave; une image Bitma
p choisie par l'utilisateur.
<br /><a name='source-exemple'></a><h2> Source / E
xemple : </h2>
<br /><pre class='code' data-mode='basic'>
//-----------------
------
        // Prend le tampon pour appliquer les règles de développement, P
aramètre : l'indice du thread
        //-----------------------
        static
 private void Génération(object Numéro)
        {
            //Détermine sur 
quelle partie du buffer on travail
            int NuméroThread = (int)Numéro;

            int CellulesTotales = Programme.Fenetre.Hauteur * Programme.Fenetre
.Largeur;
            int NombreDeCellules = CellulesTotales / Programme.Thread
s;
            int OffsetDépart = NuméroThread * NombreDeCellules;
           
 int TailleLigne = Programme.Fenetre.Largeur;
            byte[] Tampon = Progr
amme.TamponModèle;

            //Remplissage
            for (int Indice = 0
; Indice &lt; NombreDeCellules; Indice++)
            {
                //Offs
et des cellules voisines
                int HautGauche = OffsetDépart - Taille
Ligne - 1;
                int HautMilieu = OffsetDépart - TailleLigne;
      
          int HautDroite = OffsetDépart - TailleLigne + 1;

                in
t MilieuGauche = OffsetDépart - 1;
                int MilieuMilieu = OffsetDép
art;
                int MilieuDroite = OffsetDépart + 1;

                in
t BasGauche = OffsetDépart + TailleLigne - 1;
                int BasMilieu = O
ffsetDépart + TailleLigne;
                int BasDroite = OffsetDépart + Taill
eLigne + 1;

                //Valeur des cellules voisines à partir du tampon
 modèle
                //Système d'élimination des bords approximatif, mais pl
us rapide
                byte CelulleHautGauche;
                byte Celulle
HautMilieu;
                byte CelulleHautDroite;
                byte Celul
leMilieuGauche;

                if (HautGauche &gt; 0)
                {
  
                  CelulleHautGauche = Tampon[HautGauche];
                    C
elulleHautMilieu = Tampon[HautMilieu];
                    CelulleHautDroite = 
Tampon[HautDroite];
                    CelulleMilieuGauche = Tampon[MilieuGauc
he];                    
                }
                else
             
   {
                    CelulleHautGauche = 255;
                    CelulleH
autMilieu = 255;
                    CelulleHautDroite = 255;
                
    CelulleMilieuGauche = 255;
                }

                byte Celull
eMilieuMilieu = Tampon[MilieuMilieu];

                byte CelulleMilieuDroit
e;
                byte CelulleBasGauche;
                byte CelulleBasMilie
u;
                byte CelulleBasDroite;
                if (BasDroite &lt; P
rogramme.TamponTravail.Length)
                {
                    CelulleMi
lieuDroite = Tampon[MilieuDroite];
                    CelulleBasGauche = Tampo
n[BasGauche];
                    CelulleBasMilieu = Tampon[BasMilieu];
      
              CelulleBasDroite = Tampon[BasDroite];
                }
        
        else
                {
                    CelulleMilieuDroite = 255;

                    CelulleBasGauche = 255;
                    CelulleBasMili
eu = 255;
                    CelulleBasDroite = 255;
                }

   
             int Total = 0;
                if (CelulleHautGauche == 0) Total++
;
                if (CelulleHautMilieu == 0) Total++;
                if (Cel
ulleHautDroite == 0) Total++;
                if (CelulleMilieuGauche == 0) Tot
al++;
                if (CelulleMilieuDroite == 0) Total++;
                i
f (CelulleBasGauche == 0) Total++;
                if (CelulleBasMilieu == 0) T
otal++;
                if (CelulleBasDroite == 0) Total++;

                
//Case actuelle noire : prend la 'bonne' couleur si il y en 3 autres à coté
   
             if (CelulleMilieuMilieu != 0)
                {
                 
   //Résultat :
                    if (Total == 3) Programme.TamponTravail[Mil
ieuMilieu] = 0;
                    else Programme.TamponTravail[MilieuMilieu] 
= 255;
                }                
                //Case actuelle plein
e : reste en vie seulement si 2 ou 3 voisines
                else
           
     {
                    //Résultat :
                    if (Total == 3 || 
Total == 2) Programme.TamponTravail[MilieuMilieu] = 0;
                    else
 Programme.TamponTravail[MilieuMilieu] = 255;
                }

            
    OffsetDépart++;
            }
            
            //Indique qu'une o
pération est fini
            lock (Programme.Verrou) { Programme.Complétion++;
 }
        }
</pre>
<br /><a name='conclusion'></a><h2> Conclusion : </h2>

<br />// Mise &agrave; jour 06/11/2011 :
<br />
<br />- Modification de la cla
sse 'Pixel' en classe 'Couleur', plus succincte.
<br />- La cr&eacute;ation de 
l'image est d&eacute;sormais elle-aussi acc&eacute;l&eacute;r&eacute;e par Threa
dPooling.
<br />- Factorisation du code d&eacute;terminant la vie ou la mort d'
une cellule.
<br />- Utilisation d'une r&eacute;f&eacute;rence directe au tampo
n contenant l'image pr&eacute;c&eacute;dente pour &eacute;viter l'appel (lent) &
agrave; l'accesseur.
<br />
<br />- L'IHM affiche d&eacute;sormais le temps de
 conversion 'Cellules -&gt; Image' en plus du temps de g&eacute;n&eacute;ration.

<br />- L'IHM utilise d&eacute;sormais des timers pour l'affichage CPU/M&eacut
e;moire au lieu de l'afficher &agrave; chaque g&eacute;n&eacute;ration.
<br />-
 Le chargement d'image s'adapte d&eacute;sormais aux dimensions (lev&eacute;e de
 la contrainte de 64x64 pixels).
<br />- Changement du syst&egrave;me qui v&eac
ute;rifiait la fin des ThreadPool : chaque thread a d&eacute;sormais sa propre '
case', ce qui &eacute;vite les probl&egrave;mes de concurrence.
<br />
<br />-
----------------------------------------------------------------------------
<b
r />
<br />N'h&eacute;sitez pas &agrave; poser vos questions / remarques / cons
eils / etc ...
<br />
<br />Merci ;-)

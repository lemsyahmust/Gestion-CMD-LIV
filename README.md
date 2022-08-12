# Gestion-CMD-LIV

<h2> I. Introduction </h2>

* Notre objectif était de réaliser cette application. Son écoute et ses conseils nous ont permis de bien comprendre la technologie ADO.NET qui est un ensemble de composants logiciels que les programmeurs peuvent utiliser pour accéder à des services de données à partir d' une base de données.

* Notre objectif est de réaliser l’analyse à l’aide de schéma UML (notamment Diagramme de cas d'utilisation, Diagramme de séquence basique et diagramme de classe).


<h2> II. Fonctionnalité de l’application  </h2>

* Notre application se compose de deux parties :
La Première Partie C'est La Gestion Des Commandes : 
Lorsqu'un client passe une commande, celle-ci sera réalisée par un agent dit “Commercial”. L’accès de ce dernier est limité exclusivement au profil du compte d'utilisateur et ne peut visionner que cette partie, sans avoir la possibilité d'ajouter de nouveaux produits. L’application limite son rôle à l’activité de vente des articles qui se trouvent dans  notre stock.
Le détail de chaque commande se trouve dans la table "DETAIL_COMMANDE", et à chaque fois qu’on valide une commande, la quantité en stocks sera diminuée automatiquement dans la table "PRODUIT".

* La Deuxième Partie C'est La Gestion Des Livraisons :
C’est la réception de la marchandise qui est livrée par le Fournisseur et qui sera traitée par un agent dit “  Vendeur ”. L’accès de ce dernier est limité exclusivement au profil du compte d'utilisateur et ne peut visionner que cette partie. Cependant, il a la possibilité d'ajouter de nouveaux produits livrés par le fournisseur, et le détail de chaque livraison se trouve dans la table "DETAIL_LIVRAISON", et à chaque fois qu’on valide une livraison, la quantité de stock sera augmentée automatiquement de la table "PRODUIT ".
Les deux parties en question sont chapeautées par un troisième profil du compte d'utilisateur appelé “Administrateur”. Il a accès à l’ensemble des données de l’application (partie Gestion de Commande et Gestion Livraison).


<h2> III. Modélisation UML </h2>

<h3>    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1.Diagramme de classe : </h3>
<br>

![Classe UML](https://user-images.githubusercontent.com/83125801/184262770-d9fa0d39-46eb-4377-9e66-f1a0b7bd075b.jpg)

<h3>    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.Diagramme de cas d'utilisation : </h3>
<br>

![Classe UML - Diagramme de cas d'utilisation       02](https://user-images.githubusercontent.com/83125801/184266064-184e1add-ac1d-47da-9813-556ac5fde47a.jpeg)

<h3>    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;3.Diagramme de séquence basique : </h3>
<br>

![Diagramme de séquence basique (2)](https://user-images.githubusercontent.com/83125801/184266177-d1f5738f-bed5-4e17-9c30-182d3d53655a.jpeg)

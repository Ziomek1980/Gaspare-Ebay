using System;
using System.Collections.Generic;
using System.Text;

namespace GaspareEbayProgramm
{
    public class EbayTemplate
    {
        //public string ReturnEbayTemplate(ebayInfo Model, List<EbayShopProductsOverwievModel> myList)
        //{
        //    TemplateCreator myTC = new TemplateCreator();


        //    return
        //        $"<meta charset='utf-8'><meta name='viewport' content='width=device-width, initial-scale=1.0'> " +
        //        $"<meta http-equiv='cache-control' content='no-cache'>" +
        //        $"<link href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css' rel='stylesheet' />" +
        //        $"<link href='https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css' rel='stylesheet' />" +
        //        $"<link href='https://www.next-trend-italy.com/ebaycss/NTIStyle.css' rel='stylesheet' />" +
        //        $"<!-- Header --> " +
        //        $"<style>" +
        //        $"</style>" +
        //        $"<div class='container-fluid'>" +
        //        $"<div class='container header'>" +
        //        $"<!-- Row -->" +
        //        $"<div class='row'>" +
        //        $"<!-- Logo -->" +
        //        $"<div class='col-sm-6 logo'><img alt='NEXT TREND ITALY' height='66' src='https://www.next-trend-italy.com/wp-content/uploads/2018/03/logoNTI.png' width='363' /></div>" +
        //        $"<!-- Suche -->" +
        //        $"<div class='col-sm-6 hidden-xs suche'>" +
        //        $"<div class='suchbutton'><a href='https://www.ebay.de/sch/next-trend-italy/m.html?_nkw=&amp;_armrs=1&amp;_ipg=&amp;_from=' target='_blank'><i class='fa fa-search'></i></a></div>" +
        //        $"<div class='suchfeld'><a href='https://www.ebay.de/sch/next-trend-italy/m.html?_nkw=&amp;_armrs=1&amp;_ipg=&amp;_from=' target='_blank'>Shop durchsuchen...</a></div>" +
        //        $"</div>" +
        //        $"<!-- Row -->" +
        //        $"</div>" +
        //        $"<!-- Header -->" +
        //        $"</div>" +
        //        $"</div>" +
        //        $"<!-- Menubar -->" +
        //        $"<div class='container-fluid kategorien'>" +
        //        $"<div class='container'>" +
        //        $"<!-- Row -->" +
        //        $"<div class='row'>" +
        //        $"<!-- Kategorien -->" +
        //        $"<!-- <ul class='hidden-xs'>" +
        //        $"<li><a href='http://www.ebay.de/sch/next-trend-italy/m.html?_nkw=&amp;_armrs=1&amp;_ipg=&amp;_from=' target='_blank'><i aria-hidden='true' class='fa fa-home'></i></a></li>" +
        //        $"<li><a href='LINK' target='_blank'>Kategorie 1</a></li>" +
        //        $"<li><a href='LINK' target='_blank'>Kategorie 2</a></li>" +
        //        $"<li><a href='LINK' target='_blank'>Kategorie 3</a></li>" +
        //        $"<li><a href='LINK' target='_blank'>Kategorie 4</a></li>" +
        //        $"<li><a href='LINK' target='_blank'>Kategorie 5</a></li>" +
        //        $"<li><a href='LINK' target='_blank'>Kategorie 6</a></li>" +
        //        $"<li><a href='LINK' target='_blank'>Kategorie 7</a></li>" +
        //        $"<li><a href='LINK' target='_blank'>Kategorie 8</a></li>" +
        //        $"</ul> -->" +
        //        $"<!-- Kategorien -->" +
        //        $"<!-- Mobil -->" +
        //        $"<!-- <ul class='resmenu hidden-lg hidden-md hidden-sm'>" +
        //        $"<li><a href='http://www.ebay.de/sch/next-trend-italy/m.html?_nkw=&amp;_armrs=1&amp;_ipg=&amp;_from=' target='_blank'><i aria-hidden='true' class='fa fa-home'></i></a></li>" +
        //        $"<li><a href='https://www.ebay.de/usr/next-trend-italy' target='_blank'><i aria-hidden='true' class='fa fa-user'></i></a></li>" +
        //        $"<li><a href='https://feedback.ebay.de/ws/eBayISAPI.dll?ViewFeedback2&amp;userid=next-trend-italy' target='_blank'><i aria-hidden='true' class='fa fa-star'></i></a></li>" +
        //        $"<li><a href='https://my.ebay.de/ws/eBayISAPI.dll?AcceptSavedSeller&amp;sellerid=next-trend-italy&amp;ssPageName=STRK:MEFS:ADDSTR&amp;rt=nc' target='_blank'><i aria-hidden='true' class='fa fa-bookmark'></i></a></li>" +
        //        $"<li><a href='https://contact.ebay.de/ws/eBayISAPI.dll?ContactUserNextGen&amp;recipient=next-trend-italy' target='_blank'><i aria-hidden='true' class='fa fa-envelope'></i></a></li>" +
        //        $"</ul> -->" +
        //        $"<!-- Mobil -->" +
        //        $"<!-- Row -->" +
        //        $"</div>" +
        //        $"<!-- Menubar -->" +
        //        $"</div>" +
        //        $"</div>" +
        //        $"<!-- Info -->" +
        //        $"<div class='container-fluid hidden-xs'>" +
        //        $"<div class='container'>" +
        //        $"<!-- Row -->" +
        //        $"<div class='row info'>" +
        //        $"<div class='col-sm-3'><i aria-hidden='true' class='fa fa-user'></i> Kompetente Beratung</div>" +
        //        $"<div class='col-sm-3'><i aria-hidden='true' class='fa fa-check'></i> Sichere und unkomplizierte Bezahlung</div>" +
        //        $"<div class='col-sm-3'><i aria-hidden='true' class='fa fa-refresh'></i> Geld-Zur&uuml;ck-Garantie</div>" +
        //        $"<div class='col-sm-3'><i aria-hidden='true' class='fa fa-star'></i> Zufriedenheitsgarantie</div>" +
        //        $"<!-- Row -->" +
        //        $"</div>" +
        //        $"<!-- Info -->" +
        //        $"    </div>" +
        //        $"</div>" +
        //        $"<!-- Slider-BG -->" +
        //        $"<div class='container-fluid slider-bg hidden-xs'>" +
        //        $"<div class='container'>" +
        //        $"<!-- Slider -->" +
        //        $"<div class='slider'>" +
        //        $"<ul>" +
        //        $"<li><img alt='' class='img-responsive' src='https://www.next-trend-italy.com/ebaycss/img-1.jpg' /></li>" +
        //        $"<li><img alt='' class='img-responsive' src='https://www.next-trend-italy.com/ebaycss/img-2.jpg' /></li>" +
        //        $"<li><img alt='' class='img-responsive' src='https://www.next-trend-italy.com/ebaycss/img-3.jpg' /></li>" +
        //        $"</ul>" +
        //        $"</div>" +
        //        $"<!-- Slider -->" +
        //        $"<!-- Slider-BG -->" +
        //        $"</div>" +
        //        $"</div>" +
        //        $"<!-- Content -->" +
        //        $"<div class='container-fluid'>" +
        //        $"<div class='container'>" +
        //        $"<!-- Row -->" +
        //        $"<div class='row art'>" +
        //        $"<h1>{ Model.Name }</h1>" +
        //        $"<!-- Artikelbilder -->" +
        //        $"<div class='col-md-6 artpic'>" +
        //        $"<div class='artikelbilder galerie'>" +
        //        $"<input checked='checked' class='anker slide' id='slide0' name='switch' type='radio' /> " +
        //            myTC.ReturnInputAnker(Model) +
        //            myTC.ReturnImagePaths(Model) +
        //        $"<!-- Thumbnails --> " +
        //            myTC.ReturnImagePathsThumbs(Model) +
        //        $"< !-- Thumbnails -->" +
        //        $" <!-- Artikelbilder -->" +
        //        $"</div>" +
        //        $"</div>" +
        //        $"<!-- Artikelbeschreibung -->" +
        //        $"<div class='col-md-6 dsc'>" +
        //        //$"<h2>Artikelbeschreibung</h2> " +
        //        //$"<p>" + Model.Desc + "</p> " +
        //        "<h2>Artikeldetails</h2>" +
        //        "<ul>" +
        //         myTC.ReturnArtikelmerkmale(Model) +
        //         myTC.ReturnMaterialien(Model) +
        //         myTC.ReturnMasse(Model) +
        //         $"</ul>" +
        //         myTC.ReturnArtikelGroesse_Grösse(Model) +
        //         myTC.ReturnArtikelGroesse_Schuhgrösse(Model) +
        //         myTC.ReturnArtikelGroesse_Grössen(Model) +
        //         $"<div class='row kaufenbox'>" +
        //         $"<div class='col-sm-6 preis'> " +
        //         $"<h3>nur&nbsp;" + Model.Price + " &euro;</h3> " +
        //         myTC.ReturnVersand(Model) +
        //         $"</div> " +
        //         $"<div class='col-sm-6'>" +
        //         $"<!-- SOFORT KAUFEN -->" +
        //         $"<!-- BEOBACHTEN -->" +
        //         myTC.ReturnArtikelBeobachten(Model) +
        //         myTC.ReturnFrageStellen(Model) +
        //         $"<!-- FRAGE STELLEN -->" +
        //         $"<!-- Buttons -->" +
        //         $"</div>" +
        //         $"</div>" +
        //         $"<!-- Artikelbeschreibung -->" +
        //         $"</div>" +
        //         $"<!-- Row -->" +
        //         $"</div>" +
        //         //$"<!-- Tabs -->" +
        //         //$"<div class='tabs'>" +
        //         //$"<input checked='checked' id='tab1' name='tabs' type='radio' /> <label for='tab1'><span>Beschreibung</span></label> <input id='tab2' name='tabs' type='radio' /> <label for='tab2'><span> Mehrere Artikel kaufen</span></label> <input id='tab3' name='tabs' type='radio' /> <label for='tab3'><span>Our Languages </span></label>" +
        //         //$"<div class='tab-content' id='tab-content1'>" +
        //         //$"<h2>Übersicht</h2>" +
        //         //$"<ul>" +
        //         //myTC.ReturnArtikelmerkmale(Model) +
        //         //$"</ul>" +
        //         //$"</div>" +
        //         //$"<div class='tab-content' id='tab-content2'>" +
        //         //$"<h2>Kombiversand / Versandkosten nur einmal berechnen</h2>" +
        //         //$"Um die Versandkosten nur einmal zu berechnen, klicken Sie bitte auf den Button 'Jetzt Bezahlen' erst nachdem die " +
        //         //$"Versandkosten von uns angepasst wurden. <br />" +
        //         //$"Nur so können die Versandkosten nur einmal berechnet werden." +
        //         //$"<br /><br />" +
        //         //$"Der Versand der Bestellung erfolgt mit DHL oder Hermes. <br />" +
        //         //$"<img style='margin: 12px 0' width='150' alt='DHL' src='https://www.freeiconspng.com/uploads/dhl-icon-15.jpg' />" +
        //         //$"<br />" +
        //         //$"Bitte kontaktieren Sie uns, falls anderer Paketdienst erwünscht ist." +
        //         //$"</div>" +
        //         //$"<div class='tab-content' id='tab-content3'>" +
        //         //$"<h2>Our languages / Wir Sprechen</h2>" +
        //         //$"<blockquote>" +
        //         //$"<ul>" +
        //         //$"<li><img alt='Germany' src='https://github.com/gosquared/flags/blob/master/flags/flags/flat/24/Germany.png?raw=true' /> Deutsch</li>" +
        //         //$"<li><img alt='United-Kingdom' src='https://github.com/gosquared/flags/blob/master/flags/flags/flat/24/United-Kingdom.png?raw=true' /> English </li>" +
        //         //$"<li><img alt='Italy' src='https://github.com/gosquared/flags/blob/master/flags/flags/flat/24/Italy.png?raw=true' /> Italiano </li>" +
        //         //$"<li><img alt='Poland' src='https://github.com/gosquared/flags/blob/master/flags/flags/flat/24/Poland.png?raw=true' /> Polski </li>" +
        //         //$"<li><img alt='Russia' src='https://github.com/gosquared/flags/blob/master/flags/flags/flat/24/Russia.png?raw=true' /> Russia </li>" +
        //         //$"<li><img alt='Ukraine' src='https://github.com/gosquared/flags/blob/master/flags/flags/flat/24/Ukraine.png?raw=true' /> Ukraine</li>" +
        //         //$"</ul>" +
        //         //$"</blockquote>" +
        //         //$"</div>" +
        //         //$"<!-- Tabs -->" +
        //         //$"</div>" +
        //         //$"<!-- Service -->" +
        //         //$"<div class='row service'>" +
        //         //$"<div class='col-md-3'>" +
        //         //$"<div>" +
        //         //$"<i class='fa fa-truck'></i>" +
        //         //$"<h2> Versand am gleichen Tag</h2>" +
        //         //$"wenn Sie bis 14 Uhr bezahlen, versenden wir noch am gleichen Tag." +
        //         //$"</div>" +
        //         //$"</div>" +
        //         //$"<div class='col-md-3'>" +
        //         //$"<div>" +
        //         //$"<i class='fa fa-refresh'></i>" +
        //         //$"<h2>30 Tage Widerrufsrecht</h2>" +
        //         //$"Sie k&ouml;nnen den Artikel innerhalb 30 Tagen zur&uuml;ckgeben." +
        //         //$"</div>" +
        //         //$"</div>" +
        //         //$"<div class='col-md-3'>" +
        //         //$"<div>" +
        //         //$"<i class='fa fa-trophy'></i>" +
        //         //$"<h2>Geld-Zur&uuml;ck-Garantie</h2>" +
        //         //$"Unkomplizierte R&uuml;ckgabe und R&uuml;ckerstattung des Kaufpreises." +
        //         //$"</div>" +
        //         //$"</div>" +
        //         //$"<div class='col-md-3'>" +
        //         //$"<div>" +
        //         //$"<i class='fa fa-user'></i>" +
        //         //$"<h2>Kompetenter Support</h2>" +
        //         //$"Wir beraten Sie gerne zu unseren angebotenen Produkten." +
        //         //$"</div>" +
        //         //$"</div>" +
        //         //$"<!-- Service -->" +
        //         //$"</div>" +
        //         $"<!-- Cross-Selling -->" +
        //         $"<h1>Weitere Angebote aus unserem Shop</h1>" +
        //         $"<div class='row'>" +
        //         myTC.OptionalProducts(myList) +
        //         $"</div>" +
        //         $"</div>" +
        //         $"<!-- Cross-Selling -->" +
        //         $"<!-- Content -->" +
        //         $"</div>" +
        //         $"</div>" +
        //         $"<!-- Newsletter-BG -->" +
        //         $"<!-- Newsletter -->" +
        //         $"<div class='container-fluid nws'>" +
        //         $"<div class='container'>" +
        //         $"<div class='row'>" +
        //         $"<div class='col-sm-8'><i aria-hidden='true' class='fa fa-envelope-o'></i> Angebote bequem per E-Mail erhalten</div>" +
        //         $"<div class='col-sm-4'>" +
        //         $"<a class='news' href='https://my.ebay.de/ws/eBayISAPI.dll?AcceptSavedSeller&amp;sellerid=next-trend-italy&amp;ssPageName=STRK:MEFS:ADDSTR&amp;rt=nc' target='_blank'>Newsletter abonnieren</a>" +
        //         $"</div>" +
        //         $"</div>" +
        //         $"</div>" +
        //         $"</div>" +
        //         $"<!-- Newsletter -->" +
        //         $"<!-- Newsletter-BG -->" +
        //         $"<!-- Footer-BG -->" +
        //         $"<div class='container-fluid footer'>" +
        //         $"<div class='container'>" +
        //         $"<!-- Footer -->" +
        //         $"<div class='row'>" +
        //         $"<div class='col-md-3'>" +
        //         $"<h6>Links</h6>" +
        //         $"<ul>" +
        //         $"<li><a href='http://www.ebay.de/sch/next-trend-italy/m.html?_nkw=&amp;_armrs=1&amp;_ipg=&amp;_from=' target='_blank'>Unser Shop</a></li>" +
        //         $"<li><a href='https://www.ebay.de/usr/next-trend-italy' target='_blank'>Verk&auml;uferprofil</a></li>" +
        //         $"<li><a href='https://feedback.ebay.de/ws/eBayISAPI.dll?ViewFeedback2&amp;userid=next-trend-italy' target='_blank'>Bewertungen</a></li>" +
        //         $"<li><a href='https://my.ebay.de/ws/eBayISAPI.dll?AcceptSavedSeller&amp;sellerid=next-trend-italy&amp;ssPageName=STRK:MEFS:ADDSTR&amp;rt=nc' target='_blank'>Shop speichern</a></li>" +
        //         $"<li><a href='https://contact.ebay.de/ws/eBayISAPI.dll?ContactUserNextGen&amp;recipient=next-trend-italy' target='_blank'>Kontakt</a></li>" +
        //         $"</ul>" +
        //         $"</div>" +
        //         $"<div class='col-md-3'>" +
        //         $"<h6>Zahlung</h6>" +
        //         $"<p class='zvb'>" +
        //         $"<i class='fa fa-paypal fa-fw'></i> Paypal<br />" +
        //         $"<i class='fa fa-bank fa-fw'></i> &Uuml;berweisung<br />" +
        //         $"<i class='fa fa-credit-card fa-fw'></i> Kreditkarte" +
        //         $"</p>" +
        //         $"</div>" +
        //         $"<div class='col-md-3'>" +
        //         $"<h6>Versand</h6>" +
        //         $"<p class='zvb'>" +
        //         $"Der Versand der Bestellung erfolgt mit DHL oder Hermes." +
        //         $"<img alt='DHL' src='https://www.freeiconspng.com/uploads/dhl-icon-15.jpg' />" +
        //         $"</p>" +
        //         $"</div>" +
        //         $"<div class='col-md-3'>" +
        //         $"<h6>Kontakt</h6>" +
        //         $"<p>Haben Sie Fragen zu unseren Angeboten? Kontaktieren Sie uns &uuml;ber das eBay Kontaktformular.</p>" +
        //         $"<a class='kontakt' href='https://contact.ebay.de/ws/eBayISAPI.dll?ContactUserNextGen&amp;recipient=next-trend-italy' target='_blank'>eBay Nachricht</a>" +
        //         $"</div>" +
        //         $"<!-- Footer -->" +
        //         $"</div>" +
        //         $"<!-- Footer-BG -->" +
        //         $"</div>" +
        //         $"</div>";
        //}
    }
}

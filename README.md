# ProductManager — Moderní Skladový Systém

Kompletní webová aplikace pro správu skladu a katalogu produktů postavená na **ASP.NET Core (Razor Pages)** a **MongoDB**. Systém nabízí přehledné uživatelské rozhraní pro evidenci zboží, sledování stavu zásob a správu kategorií.

## 🚀 Hlavní Funkce

-   **Správa Produktů (CRUD):** Kompletní evidence zboží včetně názvů, popisů a cen.
-   **Pokročilá Skladová Evidence:**
    -   **SKU (Kód položky):** Unikátní identifikátory pro interní potřeby.
    -   **Sledování Zásob:** Vizuální indikátory pro dostatečný stav, nízký stav (varování) a vyprodáno.
    -   **Minimální Stav:** Nastavení limitu pro automatické upozornění na docházející zboží.
    -   **Lokace:** Evidence umístění ve skladu (např. regál, sekce).
    -   **Dodavatelé:** Přehled o původu zboží.
-   **Správa Kategorií:**
    -   Rychlé přidávání kategorií přímo ve formuláři produktu.
    -   Samostatná stránka pro výpis a mazání nepotřebných kategorií.
-   **Moderní UI:**
    -   Plně responzivní design (vhodné pro mobilní telefony i tablety).
    -   Interaktivní prvky (rozbalování ID na hover, hover efekty v tabulce).
    -   Full-text vyhledávání v názvech a popisech.
-   **API Rozhraní:** Podpora REST API pro integraci s externími systémy.

## 🛠️ Technologie

-   **Backend:** ASP.NET Core 10.0 (Razor Pages & Web API)
-   **Databáze:** MongoDB (dokumentově orientovaná databáze)
-   **Frontend:** HTML5, Vanilla CSS3 (moderní UI bez těžkých frameworků), JavaScript (ES6+)
-   **Konfigurace:** Podpora `.env` souborů pro citlivé údaje a `appsettings.json`.
-   **Deployment:** Připravený `Dockerfile` pro kontejnerizaci.

## 📋 Požadavky

-   [.NET 10 SDK](https://dotnet.microsoft.com/download)
-   [MongoDB](https://www.mongodb.com/try/download/community) (lokální nebo Atlas cluster)

## 🏗️ Instalace a Spuštění

1.  **Klonování repozitáře:**
    ```bash
    git clone <url-repozitare>
    cd WebApplicationASP1
    ```

2.  **Konfigurace:**
    Vytvořte v kořenu soubor `.env` nebo upravte `appsettings.json`:
    ```env
    MONGO_CONNECTION_STRING=mongodb://localhost:27017
    ```

3.  **Spuštění:**
    ```bash
    dotnet restore
    dotnet run --project WebApplicationASP1
    ```

Aplikace bude dostupná na: `https://localhost:7146` (nebo dle nastavení v `launchSettings.json`).

## 📁 Struktura Projektu

-   `/Pages`: Razor Pages pro uživatelské rozhraní (Produkty, Kategorie).
-   `/Controllers`: API endpointy pro externí přístup.
-   `/Services`: Business logika a komunikace s MongoDB.
-   `/Models`: Definice datových struktur (Product, Category).
-   `/wwwroot`: Statické soubory (CSS, JS).

## 📊 Datový Model (Product)

```json
{
  "_id": "69c15c34073a652dbdfd35e4",
  "sku": "NB-DELL-5440",
  "name": "Dell Latitude 5440",
  "description": "Firemní notebook 14\", Intel i5...",
  "price": 28990.00,
  "category": "Elektronika",
  "stock": 12,
  "minStock": 5,
  "location": "Regál A1-R2",
  "supplier": "Dell CZ",
  "createdAt": "2026-03-23T16:00:00Z"
}
```

---
Vyvinuto jako moderní řešení pro efektivní správu skladu.

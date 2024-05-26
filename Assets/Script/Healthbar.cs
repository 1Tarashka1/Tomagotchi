using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;




public class Healthbar : MonoBehaviour
{

    public UnityEngine.UI.Image CurrentHappiness;
    public UnityEngine.UI.Image CurrentHunger;
    public UnityEngine.UI.Image CurentHygeen;
    public UnityEngine.UI.Image Map;
    public UnityEngine.UI.Image CurrentHealth;
    public UnityEngine.UI.Image CurrentMoney;
    public UnityEngine.UI.Image Crystal;
    public UnityEngine.UI.Image Stick;
    public UnityEngine.UI.Image InsideBox;
    public UnityEngine.UI.Image Tie;
    public UnityEngine.UI.Image Flower;
    public UnityEngine.UI.Image ShieldGrass;
    public UnityEngine.UI.Image carpet;
    public UnityEngine.UI.Image ThornCrown;
    public UnityEngine.UI.Image ShroomInABucket;
    public UnityEngine.UI.Image Shroom;
    public UnityEngine.UI.Image Star;
    public UnityEngine.UI.Image Sign;
    public UnityEngine.UI.Image Friend;
    public UnityEngine.UI.Image Mutation;
    public UnityEngine.UI.Image Pisklya;
    public UnityEngine.UI.Image Ascension;
    public UnityEngine.UI.Image StatsImage;

    public UnityEngine.UI.Image Pet;
    public UnityEngine.UI.Image PetSad;

    public UnityEngine.UI.Image PlayBubble;
    public UnityEngine.UI.Image FeedBubble;
    public UnityEngine.UI.Image CleanBubble;

    public TextMeshProUGUI HappinessText;
    public TextMeshProUGUI HungerText;
    public TextMeshProUGUI HygeenText;
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI MoneyText;
    public TextMeshProUGUI StatsText;
    public TextMeshProUGUI YesText;


    private float happiness = 100;
    private float hygeen = 100;
    private float hunger = 100;
    private float health = 100;
    private float max = 100;
    private float forestlevel = 0;
    private float money = 100;
    private float homelevel = 0;
    private float townlevel = 0;
    private float shroomlevel = 0;
    private float babahlevel = 0;
    private float deathlevel = 0;
    private float items = 0;

    public string[] lines;


    public UnityEngine.UI.Button Feed;
    public UnityEngine.UI.Button Clean;
    public UnityEngine.UI.Button Play;
    public UnityEngine.UI.Button Door;
    public UnityEngine.UI.Button ExitMap;
    public UnityEngine.UI.Button HomeMap;
    public UnityEngine.UI.Button TownMap;
    public UnityEngine.UI.Button ForestMap;
    public UnityEngine.UI.Button ShroomMap;
    public UnityEngine.UI.Button BabahMap;
    public UnityEngine.UI.Button DeathMap;
    public UnityEngine.UI.Button Heal;
    public UnityEngine.UI.Button Box;
    public UnityEngine.UI.Button ExitBox;
    public UnityEngine.UI.Button TieInABox;
    public UnityEngine.UI.Button Clothesoff;
    public UnityEngine.UI.Button FlowerInABox;
    public UnityEngine.UI.Button ThornCrownInABox;
    public UnityEngine.UI.Button ShroomInABox;
    public UnityEngine.UI.Button StarInABox;
    public UnityEngine.UI.Button MutationInABox;
    public UnityEngine.UI.Button AscensionInABox;
    public UnityEngine.UI.Button YesButton;

    public UnityEngine.UI.Image GameOverImage;


    void Start()
    {
        UnityEngine.UI.Button btn1 = Feed.GetComponent<UnityEngine.UI.Button>();
        btn1.onClick.AddListener(Feedpet);

        UnityEngine.UI.Button btn2 = Play.GetComponent<UnityEngine.UI.Button>();
        btn2.onClick.AddListener(Playwithpet);

        UnityEngine.UI.Button btn3 = Clean.GetComponent<UnityEngine.UI.Button>();
        btn3.onClick.AddListener(Cleanpet);

        UnityEngine.UI.Button btn4 = Door.GetComponent<UnityEngine.UI.Button>();
        btn4.onClick.AddListener(Openmap);

        UnityEngine.UI.Button btn5 = ExitMap.GetComponent<UnityEngine.UI.Button>();
        btn5.onClick.AddListener(CloseMap);

        UnityEngine.UI.Button btn6 = Heal.GetComponent<UnityEngine.UI.Button>();
        btn6.onClick.AddListener(HealPet);

        UnityEngine.UI.Button btn7 = ForestMap.GetComponent<UnityEngine.UI.Button>();
        btn7.onClick.AddListener(ForestMapAction);

        UnityEngine.UI.Button btn8 = Box.GetComponent<UnityEngine.UI.Button>();
        btn8.onClick.AddListener(Openbox);

        UnityEngine.UI.Button btn9 = ExitBox.GetComponent<UnityEngine.UI.Button>();
        btn9.onClick.AddListener(Closebox);

        UnityEngine.UI.Button btn10 = TieInABox.GetComponent<UnityEngine.UI.Button>();
        btn10.onClick.AddListener(putontie);

        UnityEngine.UI.Button btn11 = Clothesoff.GetComponent<UnityEngine.UI.Button>();
        btn11.onClick.AddListener(noclothes);

        UnityEngine.UI.Button btn12 = HomeMap.GetComponent<UnityEngine.UI.Button>();
        btn12.onClick.AddListener(HomeMapAction);

        UnityEngine.UI.Button btn13 = FlowerInABox.GetComponent<UnityEngine.UI.Button>();
        btn13.onClick.AddListener(putonflower);

        UnityEngine.UI.Button btn14 = TownMap.GetComponent<UnityEngine.UI.Button>();
        btn14.onClick.AddListener(TownMapAction);

        UnityEngine.UI.Button btn15 = ThornCrownInABox.GetComponent<UnityEngine.UI.Button>();
        btn15.onClick.AddListener(putonthorncrown);

        UnityEngine.UI.Button btn16 = ShroomMap.GetComponent<UnityEngine.UI.Button>();
        btn16.onClick.AddListener(ShroomMapAction);

        UnityEngine.UI.Button btn17 = ShroomInABox.GetComponent<UnityEngine.UI.Button>();
        btn17.onClick.AddListener(putonshroom);

        UnityEngine.UI.Button btn18 = StarInABox.GetComponent<UnityEngine.UI.Button>();
        btn18.onClick.AddListener(putonstar);

        UnityEngine.UI.Button btn19 = BabahMap.GetComponent<UnityEngine.UI.Button>();
        btn19.onClick.AddListener(BabahMapAction);

        UnityEngine.UI.Button btn20 = MutationInABox.GetComponent<UnityEngine.UI.Button>();
        btn20.onClick.AddListener(putonmutation);

        UnityEngine.UI.Button btn21 = DeathMap.GetComponent<UnityEngine.UI.Button>();
        btn21.onClick.AddListener(DeathMapAction);

        UnityEngine.UI.Button btn22 = AscensionInABox.GetComponent<UnityEngine.UI.Button>();
        btn22.onClick.AddListener(putonascension);

        UnityEngine.UI.Button btn23 = YesButton.GetComponent<UnityEngine.UI.Button>();
        btn23.onClick.AddListener(ClickYes);


        PlayBubble.CrossFadeAlpha(0, 0.001f, true);
        CleanBubble.CrossFadeAlpha(0, 0.001f, true);
        FeedBubble.CrossFadeAlpha(0, 0.001f, true);

        PetSad.gameObject.SetActive(false);
        Map.gameObject.SetActive(false);
        ExitMap.gameObject.SetActive(false);
        HomeMap.gameObject.SetActive(false);
        TownMap.gameObject.SetActive(false);
        ForestMap.gameObject.SetActive(false);
        ShroomMap.gameObject.SetActive(false);
        BabahMap.gameObject.SetActive(false);
        DeathMap.gameObject.SetActive(false);
        Crystal.gameObject.SetActive(false);
        Stick.gameObject.SetActive(false);
        InsideBox.gameObject.SetActive(false);
        ExitBox.gameObject.SetActive(false);
        Tie.gameObject.SetActive(false);
        TieInABox.gameObject.SetActive(false);
        Clothesoff.gameObject.SetActive(false);
        ShieldGrass.gameObject.SetActive(false);
        Flower.gameObject.SetActive(false);
        FlowerInABox.gameObject.SetActive(false);
        carpet.gameObject.SetActive(false);
        ThornCrown.gameObject.SetActive(false);
        ThornCrownInABox.gameObject.SetActive(false);
        ShroomInABucket.gameObject.SetActive(false);
        Shroom.gameObject.SetActive(false);
        Star.gameObject.SetActive(false);
        ShroomInABox.gameObject.SetActive(false);
        StarInABox.gameObject.SetActive(false);
        Sign.gameObject.SetActive(false);
        Friend.gameObject.SetActive(false);
        Mutation.gameObject.SetActive(false);
        MutationInABox.gameObject.SetActive(false);
        Pisklya.gameObject.SetActive(false);
        Ascension.gameObject.SetActive(false);
        AscensionInABox.gameObject.SetActive(false);
        GameOverImage.gameObject.SetActive(false);
        StatsImage.gameObject.SetActive(false);
        YesButton.gameObject.SetActive(false);
        

        UpdateHappinessBar();
        UpdateHungerBar();
        UpdateHygeenBar();
        UpdateHealthBar();
        UpdateMoneyBar();

        Update();
    }

    
    private void Update()
    {
        happiness -= 2.5f * Time.deltaTime;
        if (happiness < 0 )
        {
            happiness = 0;
        }

        hygeen -= 1.5f * Time.deltaTime;
        if (hygeen < 0)
        {
            hygeen = 0;
        }

        hunger -= 2.5f * Time.deltaTime;
        if (hunger < 0)
        {
            hunger = 0;
        }

        needsCheck();
        IsPetOK();

        UpdateHappinessBar();
        UpdateHungerBar();
        UpdateHygeenBar();

        QuiestionAsk();

        GameOver();
        InstantDeath();
        nomoney();

    }

    private void needsCheck()
    {
        if (hunger <= 50)
        { 
            FeedBubble.CrossFadeAlpha(1, 0.5f, true);
        } else
        {
            FeedBubble.CrossFadeAlpha(0, 0.5f, true);
        }

        if (happiness <= 60)
        {
            PlayBubble.CrossFadeAlpha(1, 0.5f, true);
        }
        else
        {
            PlayBubble.CrossFadeAlpha(0, 0.5f, true);
        }

        if (hygeen <= 30)
        {
            CleanBubble.CrossFadeAlpha(1, 0.5f, true);
        }
        else
        {
            CleanBubble.CrossFadeAlpha(0, 0.5f, true);
        }
    }

    private void IsPetOK()
    {
        if (happiness <= 60 || hygeen <= 30 || hunger <= 50 || health <= 50)
        {
            Pet.gameObject.SetActive(false);
            PetSad.gameObject.SetActive(true);
        } else
        {
            PetSad.gameObject.SetActive(false);
            Pet.gameObject.SetActive(true);
        }
    }

    private void UpdateMoneyBar()
    {
        float ratio = money / max;
        CurrentMoney.rectTransform.localScale = new Vector3(ratio, 1, 1);
        MoneyText.text = (ratio * 100).ToString("0") + "динь";
    }


    private void UpdateHealthBar()
    {
        float ratio = health / max;
        CurrentHealth.rectTransform.localScale = new Vector3(ratio, 1, 1);
        HealthText.text = (ratio * 100).ToString("0") + "%";
    }

    private void UpdateHungerBar()
    {
        float ratio = hunger / max;
        CurrentHunger.rectTransform.localScale = new Vector3(ratio, 1, 1);
        HungerText.text = (ratio * 100).ToString("0") + "%";
    }

    private void UpdateHappinessBar()
    {
        float ratio = happiness / max;
        CurrentHappiness.rectTransform.localScale = new Vector3(ratio, 1, 1);
        HappinessText.text = (ratio * 100).ToString("0") + "%";
    }

    private void UpdateHygeenBar() 
    {
        float ratio = hygeen / max;
        CurentHygeen.rectTransform.localScale = new Vector3(ratio, 1, 1);
        HygeenText.text = (ratio * 100).ToString("0") + "%";
    }

    void HealPet()
    {
        Debug.Log("Heal button has been clicked");
        health += 20;
        if (health > max)
        {
            health = max;
        }
        UpdateHealthBar();
        money -= 10;
        if (money < 0)
        {
            money = 0;
        }
        UpdateMoneyBar();
    }

    void Feedpet()
    {
        Debug.Log("Feed button has been clicked");
        hunger += 20;
        if (hunger > max)
        {
            hunger = max;
        }
        UpdateHungerBar();
        money -= 5;
        if (money < 0)
        {
            money = 0;
        }
        UpdateMoneyBar();
    }

    void Playwithpet()
    {
        Debug.Log("Play button has been clicked");
        happiness += 30;
        if (happiness > max)
        {
            happiness = max;
        }
        UpdateHappinessBar();
        money -= 5;
        if (money < 0)
        {
            money = 0;
        }
        UpdateMoneyBar();
    }

    void Cleanpet()
    {
        Debug.Log("Clean button has been clicked");
        hygeen += 50;
        if (hygeen > max)
        {
            hygeen = max;
        }
        UpdateHygeenBar();
        money -= 5;
        if (money < 0)
        {
            money = 0;
        }
        UpdateMoneyBar();
    }

    void Openmap()
    {
        Map.gameObject.SetActive(true);
        ExitMap.gameObject.SetActive(true);
        HomeMap.gameObject.SetActive(true);
        TownMap.gameObject.SetActive(true);
        ForestMap.gameObject.SetActive(true);
        ShroomMap.gameObject.SetActive(true);
        BabahMap.gameObject.SetActive(true);
        DeathMap.gameObject.SetActive(true);
    }

    void CloseMap()
    {
        Map.gameObject.SetActive(false);
        ExitMap.gameObject.SetActive(false);
        HomeMap.gameObject.SetActive(false);
        TownMap.gameObject.SetActive(false);
        ForestMap.gameObject.SetActive(false);
        ShroomMap.gameObject.SetActive(false);
        BabahMap.gameObject.SetActive(false);
        DeathMap.gameObject.SetActive(false);
    }

    void Openbox()
    {
        InsideBox.gameObject.SetActive(true);
        ExitBox.gameObject.SetActive(true);
        Clothesoff.gameObject.SetActive(true);
        if (forestlevel >= 1)
        {
            TieInABox.gameObject.SetActive(true);
        }
        if (homelevel >= 2)
        {
            FlowerInABox.gameObject.SetActive(true);
        }
        if (townlevel >= 5)
        {
            ThornCrownInABox.gameObject.SetActive(true);
        }
        if (shroomlevel >= 1)
        {
            ShroomInABox.gameObject.SetActive(true);
        }
        if (shroomlevel >= 5)
        {
            StarInABox.gameObject.SetActive(true);
        }
        if (babahlevel >= 3)
        {
            MutationInABox.gameObject.SetActive(true);
        }
        if (deathlevel >= 1)
        {
            AscensionInABox.gameObject.SetActive(true);
        }
    }

    void Closebox()
    {
        InsideBox.gameObject.SetActive(false);
        ExitBox.gameObject.SetActive(false);
        Clothesoff.gameObject.SetActive(false);
        TieInABox.gameObject.SetActive(false);
        FlowerInABox.gameObject.SetActive(false);
        ThornCrownInABox.gameObject.SetActive(false);
        ShroomInABox.gameObject.SetActive(false);
        StarInABox.gameObject.SetActive(false);
        MutationInABox.gameObject.SetActive(false);
        AscensionInABox.gameObject.SetActive(false);
    }

    void ForestMapAction()
    {
        health -= 35;
        if (health < 0)
        {
            health = 0;
        }
        UpdateHealthBar();

        money += 30;
        if (money > max)
        {
            money = max;
        }
        UpdateMoneyBar();

        forestlevel += 1;
        if (forestlevel == 3)
        {
            Crystal.gameObject.SetActive(true);
            items += 1;
        }
        if (forestlevel == 5)
        {
            Stick.gameObject.SetActive(true);
            items += 1;
        }
        if (forestlevel == 1)
        {
            Tie.gameObject.SetActive(true);
            items += 1;
        }
    }

    void HomeMapAction()
    {
        health -= 10;
        if (health < 0)
        {
            health = 0;
        }
        UpdateHealthBar();

        money += 10;
        if (money > max)
        {
            money = max;
        }
        UpdateMoneyBar();

        homelevel += 1;
        if (homelevel == 2)
        {
            Flower.gameObject.SetActive(true);
            items += 1;
        }
        if (homelevel == 5)
        {
            ShieldGrass.gameObject.SetActive(true);
            items += 1;
        }
    }

    void TownMapAction()
    {
        health -= 25;
        if (health < 0)
        {
            health = 0;
        }
        UpdateHealthBar();

        money += 20;
        if (money > max)
        {
            money = max;
        }
        UpdateMoneyBar();

        townlevel += 1;
        if (townlevel == 2)
        {
            carpet.gameObject.SetActive(true);
            items += 1;
        }
        if (townlevel == 5)
        {
            ThornCrown.gameObject.SetActive(true);
            items += 1;
        }
    }

    void ShroomMapAction()
    {
        health -= 45;
        if (health < 0)
        {
            health = 0;
        }
        UpdateHealthBar();

        money += 40;
        if (money > max)
        {
            money = max;
        }
        UpdateMoneyBar();

        shroomlevel += 1;
        if (shroomlevel == 1)
        {
            Shroom.gameObject.SetActive(true);
            items += 1;
        }
        if (shroomlevel == 5)
        {
            Star.gameObject.SetActive(true);
            items += 1;
        }
        if (shroomlevel == 3)
        {
            ShroomInABucket.gameObject.SetActive(true);
            items += 1;
        }
    }

    void BabahMapAction()
    {
        health -= 60;
        if (health < 0)
        {
            health = 0;
        }
        UpdateHealthBar();

        money += 70;
        if (money > max)
        {
            money = max;
        }
        UpdateMoneyBar();

        babahlevel += 1;
        if (babahlevel == 1)
        {
            Sign.gameObject.SetActive(true);
            items += 1;
        }
        if (babahlevel == 5)
        {
            Friend.gameObject.SetActive(true);
            items += 1;
        }
        if (babahlevel == 3)
        {
            Mutation.gameObject.SetActive(true);
            items += 1;
        }
    }

    void DeathMapAction()
    {
        health -= 90;
        if (health < 0)
        {
            health = 0;
        }
        UpdateHealthBar();

        money += 90;
        if (money > max)
        {
            money = max;
        }
        UpdateMoneyBar();

        deathlevel += 1;
        if (deathlevel == 1)
        {
            Ascension.gameObject.SetActive(true);
            items += 1;
        }
        if (deathlevel == 10)
        {
            Pisklya.gameObject.SetActive(true);
            items += 1;
        }
    }



    void GameOver()
    {
        if(happiness == 0)
        {
            if (hygeen == 0)
            {
                if (hunger == 0)
                {
                    Feed.gameObject.SetActive(false);
                    Clean.gameObject.SetActive(false);
                    Play.gameObject.SetActive(false);
                    GameOverImage.gameObject.SetActive(true);
                    Pet.gameObject.SetActive(false);
                    PetSad.gameObject.SetActive(false);
                    FeedBubble.gameObject.SetActive(false);
                    CleanBubble.gameObject.SetActive(false);
                    PlayBubble.gameObject.SetActive(false);
                    Heal.gameObject.SetActive(false);
                    Map.gameObject.SetActive(false);
                    ForestMap.gameObject.SetActive(false);
                    ShroomMap.gameObject.SetActive(false);
                    HomeMap.gameObject.SetActive(false);
                    TownMap.gameObject.SetActive(false);
                    BabahMap.gameObject.SetActive(false);
                    DeathMap.gameObject.SetActive(false);
                    ExitMap.gameObject.SetActive(false);
                    Tie.gameObject.SetActive(false);
                    Flower.gameObject.SetActive(false);
                    ThornCrown.gameObject.SetActive(false);
                    Shroom.gameObject.SetActive(false);
                    Star.gameObject.SetActive(false);
                    Mutation.gameObject.SetActive(false);
                    Ascension.gameObject.SetActive(false);
                    YesButton.gameObject.SetActive(false);
                    StatsImage.gameObject.SetActive(true);
                    StatsText.text = "You have found " + items + "/15 items";
                }
            }
        }
    }

    void InstantDeath()
    {
        if(health == 0)
        {
            happiness = 0;
            hygeen = 0;
            hunger = 0;
            UpdateHappinessBar();
            UpdateHungerBar();
            UpdateHygeenBar();
            Feed.gameObject.SetActive(false);
            Clean.gameObject.SetActive(false);
            Play.gameObject.SetActive(false);
            GameOverImage.gameObject.SetActive(true);
            Pet.gameObject.SetActive(false);
            PetSad.gameObject.SetActive(false);
            FeedBubble.gameObject.SetActive(false);
            CleanBubble.gameObject.SetActive(false);
            PlayBubble.gameObject.SetActive(false);
            Heal.gameObject.SetActive(false);
            Map.gameObject.SetActive(false);
            ForestMap.gameObject.SetActive(false);
            ShroomMap.gameObject.SetActive(false);
            HomeMap.gameObject.SetActive(false);
            TownMap.gameObject.SetActive(false);
            BabahMap.gameObject.SetActive(false);
            DeathMap.gameObject.SetActive(false);
            ExitMap.gameObject.SetActive(false);
            Tie.gameObject.SetActive(false);
            Flower.gameObject.SetActive(false);
            ThornCrown.gameObject.SetActive(false);
            Shroom.gameObject.SetActive(false);
            Star.gameObject.SetActive(false);
            Mutation.gameObject.SetActive(false);
            Ascension.gameObject.SetActive(false);
            YesButton.gameObject.SetActive(false);
            StatsImage.gameObject.SetActive(true);
            StatsText.text = "You have found " + items + "/15 items";
        }
    }

    void nomoney()
    {
        if (money == 0)
        {
            happiness = 0;
            hygeen = 0;
            hunger = 0;
            health = 0;
            UpdateHappinessBar();
            UpdateHungerBar();
            UpdateHygeenBar();
            UpdateHealthBar();
            Feed.gameObject.SetActive(false);
            Clean.gameObject.SetActive(false);
            Play.gameObject.SetActive(false);
            GameOverImage.gameObject.SetActive(true);
            Pet.gameObject.SetActive(false);
            PetSad.gameObject.SetActive(false);
            FeedBubble.gameObject.SetActive(false);
            CleanBubble.gameObject.SetActive(false);
            PlayBubble.gameObject.SetActive(false);
            Heal.gameObject.SetActive(false);
            Map.gameObject.SetActive(false);
            ForestMap.gameObject.SetActive(false);
            ShroomMap.gameObject.SetActive(false);
            HomeMap.gameObject.SetActive(false);
            TownMap.gameObject.SetActive(false);
            BabahMap.gameObject.SetActive(false);
            DeathMap.gameObject.SetActive(false);
            ExitMap.gameObject.SetActive(false);
            Tie.gameObject.SetActive(false);
            Flower.gameObject.SetActive(false);
            ThornCrown.gameObject.SetActive(false);
            Shroom.gameObject.SetActive(false);
            Star.gameObject.SetActive(false);
            Mutation.gameObject.SetActive(false);
            Ascension.gameObject.SetActive(false);
            YesButton.gameObject.SetActive(false);
            StatsImage.gameObject.SetActive(true);
            StatsText.text = "You have found " + items + "/15 items";
        }
    }

    void putontie()
    {
        Tie.gameObject.SetActive(true);
    }

    void putonflower()
    {
        Flower.gameObject.SetActive(true);
    }

    void putonthorncrown()
    {
        ThornCrown.gameObject.SetActive(true);
    }

    void putonshroom()
    {
        Shroom.gameObject.SetActive(true);
    }

    void putonstar()
    {
        Star.gameObject.SetActive(true);
    }

    void putonmutation()
    {
        Mutation.gameObject.SetActive(true);
    }

    void putonascension()
    {
        Ascension.gameObject.SetActive(true);
    }

    void noclothes()
    {
        Tie.gameObject.SetActive(false);
        Flower.gameObject.SetActive(false);
        ThornCrown.gameObject.SetActive(false);
        Shroom.gameObject.SetActive(false);
        Star.gameObject.SetActive(false);
        Mutation.gameObject.SetActive(false);
        Ascension.gameObject.SetActive(false);
    }
   
    void QuiestionAsk()
    {
        if (items == 7)
        {
            YesButton.gameObject.SetActive(true);
        }
        if (items == 15)
        {
            YesText.text = "!";
        }
    }

    void ClickYes()
    {
        if (items == 7)
        {
            SceneManager.LoadScene("Ending 1");
        }
        if (items == 15)
        {
            SceneManager.LoadScene("Ending 2");
        }
    }

}

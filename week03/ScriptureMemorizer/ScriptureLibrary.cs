using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
public class ScriptureLibrary
{

    private List<Scripture> _allScriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _allScriptures = new List<Scripture>();
        _random = new Random();
        ScriptureList();
    }

    private void ScriptureList()
    {
        Reference ref1 = new Reference("Helaman", 5, 12);
        Scripture scripture1 = new Scripture(ref1, "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        _allScriptures.Add(scripture1);

        Reference ref2 = new Reference("2 Nephi", 2, 2);
        Scripture scripture2 = new Scripture(ref2, "Nevertheless, Jacob, my firstborn ,in the wilderness, thou knowest the greatness of God; and he shall consecrate thine afflictions for thy gain.");
        _allScriptures.Add(scripture2);

        Reference ref3 = new Reference("1 Nephi", 3, 7);
        Scripture scripture3 = new Scripture(ref3, "And may the Lord consecrate also unto thee this land, which is a most precious land, for thine inheritance and the inheritance of thy seed with thy brethren, for thy security forever, if it so be that ye shall keep the commandments of the Holy One of Israel.");
        _allScriptures.Add(scripture3);

        Reference ref4 = new Reference("Mosiah", 18, 8, 10);
        Scripture scripture4 = new Scripture(ref4, "And it came to pass that he said unto them: Behold, here are the waters of Mormon (for thus were they called) and now, as ye are desirous to come into the fold of God, and to be called his people, and are willing to bear one another’s burdens, that they may be light; Yea, and are willing to mourn with those that mourn; yea, and comfort those that stand in need of comfort, and to stand as witnesses of God at all times and in all things, and in all places that ye may be in, even until death, that ye may be redeemed of God, and be numbered with those of the first resurrection, that ye may have eternal life— Now I say unto you, if this be the desire of your hearts, what have you against being baptized in the name of the Lord, as a witness before him that ye have entered into a covenant with him, that ye will serve him and keep his commandments, that he may pour out his Spirit more abundantly upon you?");
        _allScriptures.Add(scripture4);

        Reference ref5 = new Reference("3 Nephi", 11, 14);
        Scripture scripture5 = new Scripture(ref5, "Arise and come forth unto me, that ye may thrust your hands into my side, and also that ye may feel the prints of the nails in my hands and in my feet, that ye may know that I am the God of Israel, and the God of the whole earth, and have been slain for the sins of the world.");
        _allScriptures.Add(scripture5);

        Reference ref6 = new Reference("Jacob", 3, 2);
        Scripture scripture6 = new Scripture(ref6, "And may the Lord consecrate also unto thee this land, which is a most precious land, for thine inheritance and the inheritance of thy seed with thy brethren, for thy security forever, if it so be that ye shall keep the commandments of the Holy One of Israel.");
        _allScriptures.Add(scripture6);

        Reference ref7 = new Reference("Ether", 12, 27);
        Scripture scripture7 = new Scripture(ref7, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        _allScriptures.Add(scripture7);


        Reference ref8 = new Reference("Moroni", 10, 4, 5);
        Scripture scripture8 = new Scripture(ref8, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");
        _allScriptures.Add(scripture8);
    }

    public Scripture GetRandomScripture()
    {
        int randomNumber = _random.Next(0, _allScriptures.Count);
        return _allScriptures[randomNumber];
    }

}


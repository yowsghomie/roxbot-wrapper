# roxbot wrapper

> 1. include the dll as a reference in your project
> 2. add **using RoxbotWrapper;**
> 3. profit???

## example
```csharp
using RoxbotWrapper;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Roxbot.GetPoints("username");
            Roxbot.GetRank("username");
            Roxbot.GetKills("username");
            Roxbot.GetDeaths("username");
            Roxbot.GetRatio("username");
            Roxbot.GetDamageTaken("username");
            Roxbot.GetDamageDealt("username");
            Roxbot.GetBestStreak("username");
            Roxbot.GetBestMulti("username");
            Roxbot.GetBowAccuracy("username");
            Roxbot.GetTimePlayed("username");
        }
    }
}

```


## methods
#### GetRank (username)
> returns current rank of the user

#### GetPoints (username)
> returns amount of points a user has

#### GetKills (username)
> returns amount of kills a user has

#### GetDeaths (username)
> returns amount of deaths a user has

#### GetRatio (username)
> returns the kill / death ratio

#### GetDamageTaken (username)
> returns amount of damage taken

#### GetDamageDealt (username)
> returns amount of damage dealt

#### GetBestStreak (username)
> returns best kill streak

#### GetBestMulti (username)
> returns user best multi

#### GetBowAccuracy (username)
> returns the user bow accuracy

#### GetTimePlayed (username)
> returns the user time played in hours

uhhh yeah enjoy <3

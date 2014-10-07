using TheSlum.BonusItems;
using TheSlum.Characters;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    public class ReloadedEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            string command = inputParams[0];

            switch (command)
            {
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            string characterType = inputParams[1];
            string characterId = inputParams[2];
            int xCoordinate = int.Parse(inputParams[3]);
            int yCoordinate = int.Parse(inputParams[4]);
            Team team = inputParams[5] == "Red" ? Team.Red : Team.Blue;

            switch (characterType)
            {
                case "mage":
                    this.characterList.Add(new Mage(characterId, xCoordinate, yCoordinate, team));
                    break;
                case "warrior":
                    this.characterList.Add(new Warrior(characterId, xCoordinate, yCoordinate, team));
                    break;
                case "healer":
                    this.characterList.Add(new Healer(characterId, xCoordinate, yCoordinate, team));
                    break;
                default:
                    break;
            }
        }

        public new void AddItem(string[] inputParams)
        {
            Character itemReciever = base.GetCharacterById(inputParams[1]);
            string itemClass = inputParams[2];
            string itemId = inputParams[3];

            switch (itemClass)
            {
                case "injection":
                    itemReciever.AddToInventory(new Injection(itemId));
                    break;
                case "pill":
                    itemReciever.AddToInventory(new Pill(itemId));
                    break;
                case "axe":
                    itemReciever.AddToInventory(new Axe(itemId));
                    break;
                case "shield":
                    itemReciever.AddToInventory(new Shield(itemId));
                    break;
                default:
                    break;
            }
        }
    }
}

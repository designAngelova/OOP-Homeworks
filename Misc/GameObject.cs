using NeltharionRPGGame.Helper;
using NeltharionRPGGame.Interfaces;
using NeltharionRPGGame.Structure;

namespace NeltharionRPGGame
{
    public abstract class GameObject : IGameObject, IRenderable
    {
        protected GameObject(Position position, ObjectSize size, SpriteType spriteType)
        {
            this.Position = position;
            this.Size = size;
            this.SpriteType = spriteType;
        }

        public Position Position { get; set; }

        public ObjectSize Size { get; set; }

        public SpriteType SpriteType { get; set; }
    }
}

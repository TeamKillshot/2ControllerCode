using FarseerPhysics.Dynamics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarseerExperiment
{
    class DrawablePhysicsObject
    {

        public DrawablePhysicsObject(World worls, Texture2D texture, float diameter, float mass)
        {
            size = new Vector2(diameter, diameter);

        }
    }
}

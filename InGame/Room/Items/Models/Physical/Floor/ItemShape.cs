﻿#region GPLv3

// 
// Copyright (C) 2012  Chris Chenery
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 

#endregion

namespace IHI.Server
{
    /// <summary>
    ///   Describes the shape of a floor furni.
    /// </summary>
    public class ItemShape
    {
        private CollisionType fCollision;
        private byte fHeight;
        private byte fLength;
        private byte fWidth;

        public byte GetLength()
        {
            return fLength;
        }

        public byte GetWidth()
        {
            return fWidth;
        }

        public byte GetHeight()
        {
            return fHeight;
        }

        public CollisionType GetCollision()
        {
            return fCollision;
        }
    }
}
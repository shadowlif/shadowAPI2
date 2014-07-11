﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shadowAPI2
{
    public class Vehicle
    {
        private static Vehicle instance;

        private Vehicle()
        {

        }

        public static Vehicle GetInstance()
        {
            if (instance == null)
                instance = new Vehicle();

            return instance;
        }


        private uint IsInVehicle() // TODO In Player class?
        {
            if (!Memory.IsInit)
                Memory.Init();

            uint result = BitConverter.ToUInt32(Memory.ReadMemory(Memory.vehicleOffsetBase, 4), 0);

            return result;
        }

        public float GetDl()
        {
            uint vehicle = 0;
            float damage = -1.0f;
            if ((vehicle = IsInVehicle()) != 0)
            {
                damage = Memory.ReadFloat(vehicle + Memory.vehicleOffsetDamage);
            }

            return damage;
        }

        public float GetSpeed() // Buggy
        {
            uint vehicle = 0;
            float speed = -1.0f;
            if ((vehicle = IsInVehicle()) != 0)
            {
                float x = Math.Abs(Memory.ReadFloat(vehicle + Memory.vehicleOffsetSpeedX));
                float y = Math.Abs(Memory.ReadFloat(vehicle + Memory.vehicleOffsetSpeedY));
                float z = Math.Abs(Memory.ReadFloat(vehicle + Memory.vehicleOffsetSpeedZ));

                speed = (x + y + z) * 140;
            }

            return speed;
        }

        public int GetId()
        {
            uint vehicle = 0;
            int id = -1;
            if ((vehicle = IsInVehicle()) != 0)
            {
                id = Memory.ReadInteger(vehicle + Memory.vehicleOffsetId);
            }

            return id;
        }

        public float GetCollideStatus()
        {
            uint vehicle = 0;
            float collideStatus = -1.0f;
            if ((vehicle = IsInVehicle()) != 0)
            {
                collideStatus = Memory.ReadFloat(vehicle + Memory.vehicleOffsetCollideStatus);
            }

            return collideStatus;
        }
    }
}

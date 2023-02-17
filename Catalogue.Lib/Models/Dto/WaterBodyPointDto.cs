﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.Lib.Models.Dto
{
    public class WaterBodyPointDto : BaseDto
    {
        public string OBJECTID { get; set; }
        public string UNIQUE_ID { get; set; }
        public string CONFIDENCE { get; set; }
        public double LATITUDE { get; set; }
        public double LONGITUDE { get; set; }
        public string PHASE { get; set; }

        public double AREA_SQM { get; set; }
        public double SHAPE_Leng { get; set; }
        public double SHAPE_Area { get; set; }


        //Update Status
        public int? LastUpdatedBy { get; set; }
        public string? LastUpdatedByName { get; set; }


        //status for update
        public bool IsWaterBodyPresent { get; set; }
        public bool HasBeenVisited { get; set; }

        //visistation status
        public DateTime? LastTimeVisisted { get; set; }
        public string? LastVisistedBy { get; set; }
    }




    public class WaterBodyImportDto
    {
        public string OBJECTID { get; set; }
        public string UNIQUE_ID { get; set; }
        public string CONFIDENCE { get; set; }
        public double LATITUDE { get; set; }
        public double LONGITUDE { get; set; }
        public double AREA_SQM { get; set; }
        public double SHAPE_Leng { get; set; }
        public double SHAPE_Area { get; set; }
        public string PHASE { get; set; }   

    }


   
}

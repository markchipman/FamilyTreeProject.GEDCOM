//******************************************
//  Copyright (C) 2011-2013 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included License.txt file)        *
//                                         *
// *****************************************

using FamilyTreeProject.GEDCOM.Common;
using FamilyTreeProject.GEDCOM.Records;

namespace FamilyTreeProject.GEDCOM.Structures
{
    /// <summary>
    ///   The GEDCOMSourceEventStructure class models the GEDCOM Source Event
    /// </summary>
    public class GEDCOMSourceEventStructure : GEDCOMStructure
    {
        #region Constructors

        /// <summary>
        ///   Constructs a GEDCOMSourceEventStructure from a GEDCOMRecord
        /// </summary>
        /// <param name = "record">a GEDCOMRecord</param>
        public GEDCOMSourceEventStructure(GEDCOMRecord record) : base(record)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///   Gets the Events
        /// </summary>
        public string Events
        {
            get { return Data; }
        }

        /// <summary>
        ///   Gets the Date
        /// </summary>
        public string Date
        {
            get { return ChildRecords.GetRecordData(GEDCOMTag.DATE); }
        }

        /// <summary>
        ///   Gets the Place
        /// </summary>
        public string Place
        {
            get { return ChildRecords.GetRecordData(GEDCOMTag.PLAC); }
        }

        #endregion
    }
}
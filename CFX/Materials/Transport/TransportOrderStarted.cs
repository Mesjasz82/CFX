﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.Materials.Transport
{
    /// <summary>
    /// Sent when a new transport order is initiated.  A transport order is a directive to move
    /// materials / WIP / production units from one location to another.
    /// <code language="none">
    /// {
    ///   "TransportOrderNumber": "TR329483249830000",
    ///   "StartedBy": {
    ///     "OperatorIdentifier": "2252e28d-102c-4ec1-9f14-1981c1191b95",
    ///     "ActorType": "Human",
    ///     "FullName": "Bill Smith",
    ///     "LastName": "Smith",
    ///     "FirstName": "Bill",
    ///     "LoginName": "bill.smith@domain1.com"
    ///   },
    ///   "Comments": "Initiating new transport order.  Waiting to be kitted.",
    ///   "Status": "Pending",
    ///   "RelatedWorkOrderNumber": "WO2384702937403280032",
    ///   "Source": null,
    ///   "FinalDestination": "LINE1",
    ///   "NextCheckpoint": "SMT STAGING AREA 1",
    ///   "Materials": []
    /// }
    /// </code>
    /// </summary>
    public class TransportOrderStarted : CFXMessage
    {
        public TransportOrderStarted()
        {
            Materials = new List<MaterialPackage>();
        }

        /// <summary>
        /// The order number of the new transport order
        /// </summary>
        public string TransportOrderNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The operator who initiated the new transport order (where applicable)
        /// </summary>
        public Operator StartedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Human readable comments related to this event
        /// </summary>
        public string Comments
        {
            get;
            set;
        }

        /// <summary>
        /// The status of this transport order at the time of the event
        /// </summary>
        public TransportOrderStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// The related production work order number (where applicable)
        /// </summary>
        public string RelatedWorkOrderNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The point of origination for this this transport order.  Often
        /// will be a stock area, room, etc., but may be any location within
        /// the factory environment
        /// </summary>
        public string Source
        {
            get;
            set;
        }

        /// <summary>
        /// The final destination for this transport order 
        /// </summary>
        public string FinalDestination
        {
            get;
            set;
        }

        /// <summary>
        /// The next anticipated check point (way point) for this transport order
        /// </summary>
        public string NextCheckpoint
        {
            get;
            set;
        }

        /// <summary>
        /// A list of the specific materials, WIP, and / or production units that are to be 
        /// transported for this transport order.
        /// </summary>
        public List<MaterialPackage> Materials
        {
            get;
            set;
        }
    }
}

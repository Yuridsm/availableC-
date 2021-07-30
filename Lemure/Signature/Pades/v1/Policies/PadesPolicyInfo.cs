﻿using lemure.Signature.Pades.v1.Policies;
using lemure.Signature.PolicyInformation.SignPeriod;

namespace lemure.Signature.Pades.v1.Policies
{
    public class PadesPolicyInfo
    {
        public DirectoryString PolicyName { get; set; }
        public DirectoryString FieldOfApplication { get; set; }
        public SigningPeriod SigningPeriod { get; set; }
        #nullable enable
        public Time? RevocationDate { get; set; }
        #nullable disable
        public PoliciesURI PoliciesURI { get; set; }
        #nullable disable
        public PoliciesDigest PoliciesDigest { get; set; }
    }
}
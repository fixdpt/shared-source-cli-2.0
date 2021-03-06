//------------------------------------------------------------------------------
// <copyright file="XPathEmptyIterator.cs" company="Microsoft">
//     
//      Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//     
//      The use and distribution terms for this software are contained in the file
//      named license.txt, which can be found in the root of this distribution.
//      By using this software in any fashion, you are agreeing to be bound by the
//      terms of this license.
//     
//      You must not remove this notice, or any other, from this software.
//     
// </copyright>                                                                
//------------------------------------------------------------------------------

namespace MS.Internal.Xml.XPath {
    using System;
    using System.Xml;
    using System.Xml.XPath;
    using System.Diagnostics;
    using System.Globalization;
    using System.Collections;
    
    internal sealed class XPathEmptyIterator : ResetableIterator {
        private XPathEmptyIterator() {}
        public override XPathNodeIterator Clone() { return this; }

        public override XPathNavigator Current {
            get { return null; }
        }

        public override int CurrentPosition {
            get { return 0; }
        }

        public override int Count {
            get { return 0; }
        }

        public override bool MoveNext() {
            return false;
        }

        public override void Reset() {}

        // -- Instance
        public static XPathEmptyIterator Instance = new XPathEmptyIterator();
    }
}

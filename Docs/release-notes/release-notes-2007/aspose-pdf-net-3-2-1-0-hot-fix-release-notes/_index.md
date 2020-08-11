---
title: Aspose.Pdf .Net 3.2.1.0 Hot Fix Release Notes
type: docs
weight: 540
url: /net/aspose-pdf-net-3-2-1-0-hot-fix-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF .Net 3.2.1.0 Hot Fix](http://www.aspose.com/downloads/pdf/net/new-releases/aspose.pdf-.net-3.2.1.0-hot-fix/)

{{% /alert %}} 

In this hotfix: 

\1) 64-bit windows problem is fixed. Refer to .2) DeEntitize() bug is fixed. Refer to .3) Table background color bug is fixed. Refer to .4) Segment background color and borders are supported.5) A floating box padding bug is fixed. Refer to .6) A list indent bug is fixed. Refer to .7) A new property IsDefaultAllAllowed is added into Security class. So you can set the default permissions to be "all not allowed". Here is an example:   Security s = new Security();   s.IsDefaultAllAllowed = false;   s.IsCopyingAllowed = true;   s.IsScreenReadersAllowed = true;8) A text overlapping bug is fixed. Refer to .9) Bullet bug in BindHTML() in fixed. Refer to .10) "ChoiceOption" element is supported in XML. ChoiceOptions attribute is obsolete. Here is an example:      <FormField FormFieldType="Combo" FieldName="ACombo" FieldValue="Red 1" FormWidth="80" FormHeight="20">   <ChoiceOption>Red 1</ChoiceOption>   <ChoiceOption>Green</ChoiceOption>   <ChoiceOption>Blue</ChoiceOption>   </FormField> 

function isDevice()
{
    return /android|webos|iphone|ipad|ipod|blackberry|iemobile|opera mini|mobile/i.test(navigator.userAgent);
}

function checkCheckBox(i)
{
    document.getElementById("checkbox-" + i).checked = true;
}
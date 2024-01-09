function isDevice()
{
    return /android|webos|iphone|ipad|ipod|blackberry|iemobile|opera mini|mobile/i.test(navigator.userAgent);
}

function checkCheckBox(i)
{
    document.getElementById("checkbox-" + i).checked = true;
}

function clickHref(i)
{
    document.getElementById("href-" + i).click();
}
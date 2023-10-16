/* navigation bar -------------------------------------------------------------------- */
nav{
    display:flex;
    justify-content: space-around;
    align-items: center;
}
li{
    list-style: none;
}
.logo,
.nav-list,
#login,
#getstarted{
    font-family: Outfit;
    font-size: 18px;
    font-style:normal;
    line-height: normal;
}
.logo{
    display:flex;
    align-items: center; 
    gap:15px;
    color: black;
    font-weight: 300;

}
.nav-list{
    display:flex;
    list-style: none;
    gap:20px;
    color: #0F2137;
    font-weight: 300;
    
    
}

.login{
    display:flex;
   
    gap:10px;
}
a{
    text-decoration: none;
}
#login{
    color:#0F2137;
    font-weight:500;
}
#getstarted{
    color:#0A8080;
    font-weight:500;
}
/*-----------------------------------------------------------------------------------------------*/
.main-title{
    color: #02073E;
    text-align: center;
    font-family: Outfit;
    font-size: 40px;
    font-style: normal;
    font-weight: 700;
    line-height: normal;
    width: 75%;
    margin: auto;
    margin-top: 50px;
    margin-bottom: 50px;
}
.flex-box{
    display: flex;
    justify-content:center;
    align-items: flex-end;
    
}
/*-------form----------------------------------------------------------------------------------------------------------------------------*/
.form-input{
    width: 50%;
    height: 40px;
    border-width: 1px;
    border-radius: 10px;
    background: #D9D9D9;
    display: block;
    margin:auto;
    outline: none;
    padding-left:20px;
}
form{
   
    width: 55%;
    margin: auto;
}

.form-input.textarea{
    height:225px;
    
    resize: none;
    padding-left:20px;
}
.submit-button{
    
    height: 40px;
    display:block;
    margin:auto;
    border-radius: 10px;
    background: #0A8080;
    border-width: 1px;
    color: #FFF;
    text-align: center;
    font-family: Outfit;
    font-size: 20px;
    font-style: normal;
    font-weight: 500;
    line-height: normal;
    margin-top: 46px;
    width: 20%;

}
/*footer-----------------------------------------------------------------------------------------------*/
.nav-footer{
    display: flex;
    justify-content: space-evenly;
    align-items: center;
    margin-top: 100px;
}

.footer1,
.footer2,
.footer3,
.footer4,
.footer5{
    line-height: 25px;
    align-items: center;
}
.logo-text{
    display: flex;
    align-items: center;
    gap:5px; 
   
}
.list-margin{
    margin-bottom: 15px;
}
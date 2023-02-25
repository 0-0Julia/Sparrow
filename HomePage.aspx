<%@ Page Title="" Language="C#" MasterPageFile="~/Foundation.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Sparrow.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .bio {
	        max-height: 120px;
	        overflow: hidden;
	        position: relative;
        }
        .read-more-fade {
            display: block;
            position: absolute;
            bottom: 0px;
            width: 100%;
            height: 50px;
            background: linear-gradient(to bottom, transparent, rgb(37 33 31 / 0.80));
        }
        h1{
            background-color:#43240A;
            position:fixed;
            align-content:center;
            width: 100%;
            z-index:1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <h1><img src="pictures/Sparrow_Birds_guide.png" height="300" width="300" /></h1>
    </header>
   
    <header style="height:100px;">
    </header>
    <section>
        <fieldset>
            First of all, the reason why I chose this topic was because it's something that will probebly be interesting for me to search about and work on,
            espesialy for a long time - you will say that that's the simpelest reason ever!
            <br />
            yeah, you're right- but isn't that an importent one too?
            <br />
            <br />
            This site will contain all the needed information about having any type of bird, from how to care about them, what to be ready for and what are
            the cons and pros in having the one bird you chose.
            <br />
            In the future it will contain information about almost all the diferent birds around the world that you can have as a pet, a list of known ornitology centers and ornitologs in your area and a bird calculater that will give you the most suiteble bird to have as a pet based on your info and needs.
            <br />
            <%
                if (Session["username"] == null)
                {
                    Response.Write("For now, you can join our community and get notifications <a class='underline-animation' href='SignUp.aspx'>here</a>. <br/> <a class='underline-animation' href='SignIn.aspx'>already have an account?</a> <br/>");
                }
            %>
            Thank you and have a nice day!
        </fieldset>
   </section>
        <ul class="cards">
          <li class="cards__item">
            <div class="card">
              <div class="card__image card__image1"></div>
              <div class="card__content">
                <div class="card__title">info</div>
                <p class="card__text">info info info info duck info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info </p>
                <button class="custom-btn btn-8"><span>Read More</span></button>
              </div>
            </div>
          </li>
          <li class="cards__item">
            <div class="card">
              <div class="card__image card__image2"></div>
              <div class="card__content">
                <div class="card__title">Hover to see the results so far</div>
                <p class="card__text">got the idea from <a class="underline-animation" href="https://codepen.io/mcraiganthony/pen/NxGxqm?editors=1100">here</a>. thought this will help deal with the emptiness this page had. in the future this pages will lead to a real pages with the needed information, so basicly this site is not only a school project, it's also my own research to expand my knowledge about birds in general.</p>
                <button class="custom-btn btn-8"><span>Read More</span></button>
              </div>
            </div>
          </li>
          <li class="cards__item">
            <div class="card">
              <div class="card__image card__image3"></div>
              <div class="card__content">
                <div class="card__title">Colors</div>
                <p class="card__text">some birds have a unique colorful feathers and most of the times it's to attract females, so for that, only the male has them. But in other cases the colors are made to build a camouflage from predators and to hide in the trees or to warn them that they(the birds) are poiseness. usualy it's false and made only for protaction but some birds because of the insects they eat they can actualy be poiseness.</p>
                <button class="custom-btn btn-8"><span>Read More</span></button>  
              </div>
            </div>
          </li>
          <li class="cards__item">
            <div class="card">
              <div class="card__image card__image4"></div>
              <div class="card__content">
                <div class="card__title">info</div>
                    <p class="card__text">info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info</p>
              <button class="custom-btn btn-8"><span>Read More</span></button>              
              </div>
            </div>
          </li>
          <li class="cards__item">
            <div class="card">
              <div class="card__image card__image5"></div>
              <div class="card__content">
                <div class="card__title">Piegon as a pet?</div>
                <p class="card__text">info info info info info info info info info info info info info info info info info info info info info info info info info</p>
                <button class="custom-btn btn-8"><span>Read More</span></button>              </div>
            </div>
          </li>
         <li class="cards__item">
            <div class="card">
              <div class="card__image card__image6"></div>
              <div class="card__content">
               <div class="card__title">info</div>
                <p class="card__text">info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info info </p>
               <button class="custom-btn btn-8"><span>Read More</span></button>
              </div>
            </div>
          </li>
         </ul>
</asp:Content>

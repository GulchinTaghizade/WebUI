//---------HOME
var homedropdowncontent = document.querySelector("#home-sdb-drpdwn-content");

var homedropdown = document.querySelector("#home-sdb-drpdwn");


homedropdown.addEventListener("click", () => {
    if (homedropdowncontent.style.position == "absolute") {
        homedropdowncontent.style = "position:relative; visibility:visible";
    }
    else {
        homedropdowncontent.style = "position:absolute; visibility:hidden";
    }

}
)

//---------PAGES
var pagesdropdowncontent = document.querySelector("#pages-sdb-drpdwn-content");

var pagesdropdown = document.querySelector("#pages-sdb-drpdwn");


pagesdropdown.addEventListener("click", () => {
    if (pagesdropdowncontent.style.position == "absolute") {
        pagesdropdowncontent.style = "position:relative; visibility:visible";
    }
    else {
        pagesdropdowncontent.style = "position:absolute; visibility:hidden";
    }

}
)
//---------SHOP
var shopdropdowncontent = document.querySelector("#shop-sdb-drpdwn-content");

var shopdropdown = document.querySelector("#shop-sdb-drpdwn");


shopdropdown.addEventListener("click", () => {
    if (shopdropdowncontent.style.position == "absolute") {
        shopdropdowncontent.style = "position:relative; visibility:visible";
    }
    else {
        shopdropdowncontent.style = "position:absolute; visibility:hidden";
    }

}
)

//---------PORTFOLIO
var portfoliodropdowncontent = document.querySelector("#portfolio-sdb-drpdwn-content");

var portfoliodropdown = document.querySelector("#portfolio-sdb-drpdwn");


portfoliodropdown.addEventListener("click", () => {
    if (portfoliodropdowncontent.style.position == "absolute") {
        portfoliodropdowncontent.style = "position:relative; visibility:visible";
    }
    else {
        portfoliodropdowncontent.style = "position:absolute; visibility:hidden";
    }

}
)
//---------BLOG
var blogdropdowncontent = document.querySelector("#blog-sdb-drpdwn-content");

var blogdropdown = document.querySelector("#blog-sdb-drpdwn");


blogdropdown.addEventListener("click", () => {
    if (blogdropdowncontent.style.position == "absolute") {
        blogdropdowncontent.style = "position:relative; visibility:visible";
    }
    else {
        blogdropdowncontent.style = "position:absolute; visibility:hidden";
    }

}
)


//---------ELEMENTS
var elementsdropdowncontent = document.querySelector("#elements-sdb-drpdwn-content");

var elementsdropdown = document.querySelector("#elements-sdb-drpdwn");


elementsdropdown.addEventListener("click", () => {
    if (elementsdropdowncontent.style.position == "absolute") {
        elementsdropdowncontent.style = "position:relative; visibility:visible";
    }
    else {
        elementsdropdowncontent.style = "position:absolute; visibility:hidden";
    }

}
)

var hamburger_icon = document.querySelector("#hamburger-icon");
var sidebar = document.querySelector("#sidebar");

hamburger_icon.addEventListener("click", () => {
    if (sidebar.style == "visibility:hidden;") {
        sidebar.style = "visibility:visible;";
        hamburger_icon.style = "visibility:hidden;"
    }
    else {
        sidebar.style = "visibility:hidden;";
    }
})

//----SLIDER

var slidePosition = 1;
SlideShow(slidePosition);

// forward/Back controls
function plusSlides(n) {
    SlideShow(slidePosition += n);
}

//  images controls
function currentSlide(n) {
    SlideShow(slidePosition = n);
}

function SlideShow(n) {
    var i;
    var slides = document.getElementsByClassName("Containers");
    var circles = document.getElementsByClassName("dots");
    if (n > slides.length) { slidePosition = 1 }
    if (n < 1) { slidePosition = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < circles.length; i++) {
        circles[i].className = circles[i].className.replace(" enable", "");
    }
    slides[slidePosition - 1].style.display = "block";
    circles[slidePosition - 1].className += " enable";

}
setInterval(function () {
    plusSlides(1)
}, 5000);



// // init Isotope
// var $grid = $('#product-cards').isotope({
//     layoutMode: 'fitRows',
//   });
//   // filter items on button click
//   $('#filter').on( 'click', 'li', function() {
//     var filterValue = $(this).attr('data-filter');
//     $grid.isotope({ filter: filterValue });
//   });



filterSelection("all");
function filterSelection(c) {
  var x, i;
  x = document.getElementsByClassName("card");
  if (c == "all") c = "";
  for (i = 0; i < x.length; i++) {
    RemoveClass(x[i], "show");
    if (x[i].className.indexOf(c) > -1) AddClass(x[i], "show");
  }
};

function AddClass(element, name) {
  var i, arr1, arr2;
  arr1 = element.className.split(" ");
  arr2 = name.split(" ");
  for (i = 0; i < arr2.length; i++) {
    if (arr1.indexOf(arr2[i]) == -1) {element.className += " " + arr2[i];}
  }
};

function RemoveClass(element, name) {
  var i, arr1, arr2;
  arr1 = element.className.split(" ");
  arr2 = name.split(" ");
  for (i = 0; i < arr2.length; i++) {
    while (arr1.indexOf(arr2[i]) > -1) {
      arr1.splice(arr1.indexOf(arr2[i]), 1);     
    }
  }
  element.className = arr1.join(" ");
};

// Add active class to the current button (highlight it)

var btnContainer = document.getElementById("categories");
var btns = btnContainer.getElementsByClassName("category");
// console.log(btns);
for (var i = 0; i < btns.length; i++) {
  btns[i].addEventListener("click", function(){
    var current = document.getElementsByClassName("active");
    current[0].className = current[0].className.replace(" active", "");
    this.className += " active";
  });
};



//Local storage Basket

let buttons=document.getElementsByClassName('add-to-card');
[...buttons].forEach(btn=>{
    btn.onclick=function (e) {
        let id=this.parentElement.parentElement.getAttribute("data-id");
        let title=this.previousElementSibling.innerText;
        let price=this.nextElementSibling.innerHTML;
        let img=this.parentElement.previousElementSibling.firstElementChild.getAttribute("src");
        
        let obj={
            id:id,
            title:title,
            price: price,
            img:img,
            count:1
        }
        addBasket(obj);
    }
})

function addBasket(obj) {
    let basket=localStorage.getItem('basket');
        if (basket==null) {
            let basketArr=[obj];
            localStorage.setItem('basket',JSON.stringify(basketArr));
        }
        else{
            let basketArr=JSON.parse(basket);
            let isExist=basketArr.find(ob=>ob.id==obj.id);
            if(isExist===undefined){
                basketArr.push(obj);
            }
            else{
                isExist.count+=1;
            }
            localStorage.setItem('basket',JSON.stringify(basketArr));
        }
        
}


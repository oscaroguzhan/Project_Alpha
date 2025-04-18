document.addEventListener("DOMContentLoaded", () => {
    const previewSize = 150; // default preview size
    // open modal when button is clicked
    const modalButtons = document.querySelectorAll('[data-modal="true"]')
    modalButtons.forEach(button => {
        button.addEventListener("click", () => {
        const modalTarget = button.getAttribute("data-target");
        const modal =document.querySelector(modalTarget);
        
        if (modal) 
            {
            modal.style.display = "flex";
            }
        })
    });
    // close modal 
    const closeModalButtons = document.querySelectorAll('[data-close="true"]')
    closeModalButtons.forEach(button => {
        button.addEventListener("click", () => {
            const modal = button.closest(".modal");
            if (modal) {
                modal.style.display = "none";

                // clear form inputs
                modal.querySelectorAll('form').forEach(form => {
                    form.reset();
                    const imagePreview = form.querySelector('.image-preview');
                    if (imagePreview) {
                        imagePreview.src = ""; // clear image preview
                    }
                    const imagePreviewer = form.querySelector('.image-previewer');
                    if(imagePreviewer) {
                        imagePreviewer.classList.remove('selected'); // remove selected class

                    }
                });
            }
        });
    });
    // handle image-previwer
    document.querySelectorAll('.image-previewer').forEach(previewer => {
        const fileInput = previewer.querySelector('input[type="file"]');
        const imagePreview = previewer.querySelector('.image-preview');

        previewer.addEventListener('click', () => fileInput.click());

        fileInput.addEventListener('change', ({ target : {files} }) => {
            const file = files[0];
            if(file) {
                processImage(file, imagePreview, previewer, previewSize).then(() => {
                    console.log("Image processed successfully");
                }).catch((error) => {
                    console.error("Error processing image:", error);
                });
            }
        })
    });
});

async function loadImage(file) {
    return new Promise((resolve, reject) => {
        const reader = new FileReader();
        reader.onerror = () => reject (new Error("Failed to read file"));
        reader.onload = (e) => {
            const img = new Image();
            img.onerror = () => reject(new Error("Failed to load image"));
            img.onload = () => resolve(img);
            img.src = e.target.result;
        }
        reader.readAsDataURL(file);
    }   );
}

async function processImage(file, imagePreview, previewer, previewSize = 150) {
    try {
       const img = await loadImage(file);
        const canvas = document.createElement('canvas');
        canvas.width = previewSize;
        canvas.height = previewSize;
        const ctx = canvas.getContext('2d');

        // Calculate aspect ratio
        const ratio = Math.min(previewSize / img.width, previewSize / img.height);
        
        // Calculate new dimensions based on aspect ratio
        const width = img.width * ratio;
        const height = img.height * ratio;
        
        // Draw the image centered on the canvas
        const offsetX = (previewSize - width) / 2;
        const offsetY = (previewSize - height) / 2;

        ctx.drawImage(img, offsetX, offsetY, width, height);

        imagePreview.src = canvas.toDataURL();
        previewer.classList.add('selected');
    } catch (error) {
        console.error("Error processing image:", error);
        
    }
}

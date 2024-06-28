namespace MeridyenTente;

public partial class GlassBalconySystem : ContentPage
{
	public GlassBalconySystem()
	{
		InitializeComponent();
	}

	public void CalculateGlassSize(object sender, EventArgs e)
	{
        float systemHeightf = Convert.ToInt16(systemHight.Text);
        float middleSideWidthf = Convert.ToInt16(middleSideWidth.Text);
        float leftSideWidthf = Convert.ToInt16(leftSideWidth.Text);
        float rightSideWidthf = Convert.ToInt16(rightSideWidth.Text);

        if (leftSideWidth.Text is null ^ rightSideWidth.Text is null)
        {
            float sideWidth = leftSideWidth.Text is (null or "") ? rightSideWidthf : leftSideWidthf;
            sideWidth = rightSideWidth.Text is (null or "") ? leftSideWidthf : rightSideWidthf;

            int sidePiece = 1;

            if (leftGlassPiece.Text is (null or ""))
            {
                try
                {
                    sidePiece = Convert.ToInt16(rightGlassPiece.Text);
                }
                catch (Exception ex) { }
            }
            else if (rightGlassPiece.Text is (null or ""))
            {
                sidePiece = Convert.ToInt16(leftGlassPiece.Text);
                try
                {

                }
                catch (Exception ex) { }
            }
            else
            {
                sidePiece = DeterminePiece(sideWidth);
            }

            LBalcony(systemHeightf,middleSideWidthf,sideWidth,sidePiece);
        }
        else if (!(leftSideWidth.Text is null || rightSideWidth.Text is null))
        {
            UBalcony();
        }
        else
        {
            FlatBalcony(systemHeightf,middleSideWidthf);
        }
    }

	private void FlatBalcony(float systemHeightf, float middleSideWidthf)
	{
        int piece = middleGlassPiece.Text is (null or "") ? DeterminePiece(middleSideWidthf) : Convert.ToInt16(middleGlassPiece.Text);
        float glassWitdh = ((middleSideWidthf - 50) - ((piece - 1) * 5)) / piece;
        float glassHeight = (systemHeightf - 172);

        glassSize.Text = $"Cam Ölçüsü: \n{piece} adet {glassHeight}mm x {(int)glassWitdh}mm";
    }

	private void LBalcony(float systemHeightf, float middleSideWidthf, float sideWidthf, int sidePiece)
	{
        float sideGlassWitdh = ((sideWidthf - 55) - ((sidePiece - 1) * 5)) / sidePiece;
        float sideGlassHeight = (systemHeightf - 172);
        
        FlatBalcony(systemHeightf, middleSideWidthf);
        glassSize.Text += $"\n{sidePiece} adet {sideGlassHeight}mm x {(int)sideGlassWitdh}mm";
    }

    private void UBalcony()
    {

    }

    private int DeterminePiece(float width)
    {
        float MIN_WIDTH = 440f;
        float MAX_WIDTH = 550f;
        float glassWidth = width;
        int piece = 1;

        if (width < MIN_WIDTH) return piece;

        while (!(glassWidth > MIN_WIDTH && glassWidth < MAX_WIDTH))
        {
            glassWidth = width / (float)piece;
            piece++;
        }
        return piece;
    }

}